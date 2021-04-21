using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.UI.Helper;
using PersonalAccounting.UI.Infrastructure;
using System;
using Telerik.WinControls.UI;

namespace PersonalAccounting.UI
{
    public partial class FrmRole : BaseForm
    {
        private readonly IRoleService _roleService;
        private readonly IPermissionService _permissionService;
        private readonly IFormEntityService _formEntityService;

        private int _roleId;

        //private string _roleName = string.Empty;
        //private string _status = string.Empty;
        //private string _description = string.Empty;

        // private readonly RadTreeView _treeView = new RadTreeView();

        public static FrmRole AFrmRole;
        public static FrmRole Instance()
        {
            return AFrmRole ?? (AFrmRole = IocConfig.Container.GetInstance<FrmRole>());
        }

        public FrmRole(IRoleService roleService, IPermissionService permissionService,
            IFormEntityService formEntityService)
        {
            _roleService = roleService;
            _permissionService = permissionService;
            _formEntityService = formEntityService;
            InitializeComponent();

            //_backgroundWorker = new BackgroundWorker();
            //_backgroundWorker.DoWork += _backgroundWorker_DoWork;
            //_backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
            //_pictureBox = new PictureBox()
            //{
            //    Parent = pnl_Action,
            //    SizeMode = PictureBoxSizeMode.StretchImage,
            //    BorderStyle = BorderStyle.None,
            //    Size = new Size(356, 19),
            //    Location = new Point((pnl_Action.Width / 2) - 200, 8),
            //    //new Point(13, 101),//new Point(pnl_Data.Width / 25, pnl_Data.Height / 20),
            //    Image = CommonLibrary.Properties.Resources.Loadingvvv,
            //    Visible = false
            //};

            BindAllPermissionsFormEntities();
            rtv_Permissions.ExpandAll();
            BindGrid();
            rddl_Status.SetEnableDisableStatusDropdownList();
        }

        //private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    txt_RoleName.Text = _roleName;
        //    ddl_Status.Text = _status;
        //    txt_Description.Text = _description;
        //    rtv_Permissions = _treeView.Clone();

        //    CommonHelper.IndicatorLoading(_pictureBox, false);
        //}

        //private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    ReturnRoleDetails();
        //}

        private async void BindGrid()
        {
            rgv_Role.BeginUpdate();
            rgv_Role.DataSource = await _roleService.LoadAllViewModelAsync();
            rgv_Role.EndUpdate();
        }

        private async void BindAllPermissionsFormEntities()
        {
            var formEntities = await _formEntityService.LoadAllFormEntitiesAsync();

            rtv_Permissions.BeginUpdate();

            foreach (var formEntity in formEntities)
            {
                var entityName = formEntity.Name;
                var firstLevelNode = rtv_Permissions.Nodes.Add(entityName);
                var permissions = await _permissionService.GetAllPermissionsByFormEntityAsync(entityName);

                if (permissions == null) continue;

                foreach (var permission in permissions)
                {
                    var childItem = new RadTreeNode(permission.Name);
                    firstLevelNode.Nodes.Add(childItem);
                }
            }

            rtv_Permissions.EndUpdate();
        }

        private async void GetAllPermissionsByRole(int roleId, RadTreeView treeView)
        {
            var role = await _roleService.GetByIdAsync(roleId);
            var formEntities = await _formEntityService.LoadAllFormEntitiesAsync();
            var permissionsForRole = await _permissionService.GetAllPermissionsByRoleAsync(role);

            foreach (var formEntity in formEntities)
            {
                foreach (var node in treeView.Nodes)
                {
                    var entityName = formEntity.Name;

                    if (node.Text != entityName) continue;

                    var permissions = await _permissionService.GetAllPermissionsByFormEntityAsync(entityName);

                    if (permissions == null) continue;

                    foreach (var permission in permissions)
                    {
                        var childNode = node.Find(p => p.Text == permission.Name);
                        childNode.Checked = permissionsForRole.Contains(permission);
                    }
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Insert;
            CommonHelper.InsertAction(_mode, pnl_Data, rgv_Role, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose, txt_RoleName);

            rddl_Status.SelectedValue = 0;
        }

        private void Rgv_Role_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (rgv_Role.Enabled && rgv_Role.RowCount > 0)
            { btnModify.Enabled = true; }
            else { btnModify.Enabled = false; }
        }


        //RadTreeView UpdateTreeView(RadTreeView treeView)
        //{
        //    if (this.rtv_Permissions.InvokeRequired)
        //    {
        //        // It's on a different thread, so use Invoke.
        //        this.BeginInvoke(new MethodInvoker(() => UpdateTreeView(treeView)));
        //    }
        //    else
        //    {
        //        // It's on the same thread, no need for Invoke
        //        this.rtv_Permissions = treeView;
        //    }
        //    return treeView;
        //}

        private async void ReturnRoleDetails()
        {
            try
            {
                if (!(rgv_Role.CurrentRow is GridViewDataRowInfo dataRow)) return;

                _roleId = int.Parse(dataRow.Cells["RoleId"].Value.ToString());

                rtv_Permissions.BeginUpdate();
                GetAllPermissionsByRole(_roleId, rtv_Permissions);
                rtv_Permissions.EndUpdate();

                txt_RoleName.Text = dataRow.Cells["RoleName"].Value?.ToString();
                rddl_Status.Text = dataRow.Cells["RoleStatus"].Value?.ToString();
                txt_Description.Text = dataRow.Cells["RoleDescription"].Value?.ToString();

                //_roleName = dataRow.Cells["RoleName"].Value?.ToString();
                //_status = dataRow.Cells["RoleStatus"].Value?.ToString();
                //_description = dataRow.Cells["RoleDescription"].Value?.ToString();
            }
            catch (Exception exception)
            {
                await LoggerService.ErrorAsync(this.Name, "ReturnRoleDetails", exception.Message,
                    exception.ToDetailedString());
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
            {
                CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                return;
            }

            _mode = CommonHelper.Mode.Update;
            CommonHelper.ModifyAction(_mode, pnl_Data, rgv_Role, btnInsert, btnRegister,
                btnModify, btnDelete, btnCancel, btnClose);

            _mode = CommonHelper.Mode.Update;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _mode = CommonHelper.Mode.Cancel;
            CommonHelper.CancelAction(_mode, pnl_Data, rgv_Role, btnInsert, btnRegister, btnModify,
                btnDelete, btnCancel, btnClose);

            ReturnRoleDetails();
            //CommonHelper.IndicatorLoading(this, _pictureBox, true);
            //_backgroundWorker.RunWorkerAsync();
        }

        private void Rgv_Role_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            ReturnRoleDetails();
            //CommonHelper.IndicatorLoading(_pictureBox, true);
            //_backgroundWorker.RunWorkerAsync();
        }

        private void Btn_Expand_Click(object sender, EventArgs e)
        {
            rtv_Permissions.BeginUpdate();
            rtv_Permissions.ExpandAll();
            rtv_Permissions.EndUpdate();
        }

        private void Btn_Collapse_Click(object sender, EventArgs e)
        {
            rtv_Permissions.BeginUpdate();
            rtv_Permissions.CollapseAll();
            rtv_Permissions.EndUpdate();
        }

        private bool ValidateAllControls()
        {
            var flag = CommonHelper.ValidateControls(txt_RoleName, _errorProvider,
                           "نام نقش  را وارد نمایید")
                       || CommonHelper.ValidateControls(rtv_Permissions, _errorProvider,
                           "مجوزهای لازم برای این نقش را مشخص کنید");
            return flag;
        }

        private void Txt_RoleName_TextChanged(object sender, EventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_RoleName.Text != string.Empty && rtv_Permissions.CheckedNodes.Count > 0);
            }
        }

        private void Rtv_Permissions_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (_mode == CommonHelper.Mode.Insert)
            {
                btnRegister.Enabled = (txt_RoleName.Text != string.Empty && rtv_Permissions.CheckedNodes.Count > 0);
            }
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateAllControls()) return;
            var flag = false;
            //var dlg = new CustomDialogs(400, 200);
            var currentUser = InitialHelper.CurrentUser;
            var currentDateTime = InitialHelper.CurrentDateTime;
            var roleStatus = rddl_Status.Text;
            var roleName = txt_RoleName.Text;

            switch (_mode)
            {
                case CommonHelper.Mode.Insert:
                    try
                    {
                        if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Add))
                        {
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.CreateActionNotAllow);
                            return;
                        }

                        var newRole = new Role(roleName, currentDateTime, null,
                            currentUser.Id, roleStatus, string.Empty);

                        var status = await _roleService.CreateAsync(newRole);

                        switch (status)
                        {
                            case CreateStatus.Exist:
                                CommonHelper.ShowNotificationMessage("خطای تکرار", "این نقش تکراری می باشد");
                                txt_RoleName.Focus();
                                txt_RoleName.SelectAll();
                                break;
                            case CreateStatus.Successful:
                                flag = true;
                                CommonHelper.ShowNotificationMessage("ایجاد نقش جدید",
                                    $"نقش جدید با نام {roleName} ایجاد گردید.");

                                await LoggerService.InformationAsync(this.Name, "btnRegister_Click(Insert Mode)",
                                    $"ایجاد نقش جدید با نام {roleName} ",
                                    $"و توسط کاربر  {currentUser.UserName} ایجاد گردید.");
                                break;

                            case CreateStatus.Failure:
                                CommonHelper.ShowNotificationMessage("خطا", "خطا در ایجاد نقش");
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                    catch (Exception exception)
                    {
                        CommonHelper.ShowNotificationMessage("خطا در ثبت اطلاعات", "خطای زیر به وقوع پیوست \n" + exception.Message);
                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Insert Mode)", exception.Message,
                            exception.ToDetailedString());
                        return;
                    }
                    break;

                case CommonHelper.Mode.Update:
                    try
                    {
                        if (!InitialHelper.HasPermissionFor(this.Name, PermissionMode.Edit))
                        {
                            CommonHelper.ShowNotificationMessage(DefaultConstants.IllegalAccess, DefaultConstants.EditActionNotAllow);
                            return;
                        }

                        var currentRole = await _roleService.GetByIdAsync(_roleId);
                        currentRole.Name = roleName;
                        currentRole.UpdateBy = currentUser.Id;
                        currentRole.LastUpdate = currentDateTime;
                        currentRole.Status = roleStatus;
                        currentRole.Description = txt_Description.Text;

                        await _roleService.UpdateAsync(currentRole);

                        flag = true;
                    }
                    catch (Exception exception)
                    {
                        CommonHelper.ShowNotificationMessage("خطا در ثبت اطلاعات",
                            "خطای زیر به وقوع پیوست \n" + exception.Message);
                        await LoggerService.ErrorAsync(this.Name, "btnRegister_Click(Update Mode)", exception.Message,
                            exception.ToDetailedString());
                        return;
                    }

                    break;
                case CommonHelper.Mode.None:
                    break;
                case CommonHelper.Mode.Cancel:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (flag)
            {
                var role = await _roleService.GetByNameAsync(txt_RoleName.Text);

                foreach (var node in rtv_Permissions.Nodes)
                {
                    var formEntity = await _formEntityService.GetByNameAsync(node.Text);

                    if (formEntity == null) continue;

                    foreach (var childNode in node.Nodes)
                    {
                        var permission = await _permissionService.GetByNameAndFormEntityAsync(childNode.Text, formEntity);

                        if (permission == null) continue;

                        await _permissionService.UpdatePermissionAsync(permission, role, childNode.Checked);
                    }
                }

                //CommonHelper.ClearInputControls(pnl_Data);
                txt_RoleName.Focus();
                CommonHelper.EnableControls(pnl_Data, false);
                btnCancel.Enabled = false;
                btnInsert.Enabled = true;
                btnDelete.Enabled = true;
                rgv_Role.Enabled = true;
                BindGrid();
                CommonHelper.ShowNotificationMessage("ایجاد یا بروزرسانی نقش",
                    "نقش جدید با موفقیت ایجاد/بروزرسانی گردید.");
                await LoggerService.InformationAsync(this.Name, "btnRegister_Click-Role's Permissions",
                    $"مجوزهای مربوط به نقش  {txt_RoleName.Text} ایجاد / بروزرسانی شدند.");
            }

            btnRegister.Enabled = false;
            btnClose.Enabled = true;
            _mode = CommonHelper.Mode.None;
        }

        private void Btn_CheckAll_Click(object sender, EventArgs e)
        {
            CommonHelper.CheckUncheckTreeNode(rtv_Permissions.Nodes, true);
        }

        private void Btn_UncheckAll_Click(object sender, EventArgs e)
        {
            CommonHelper.CheckUncheckTreeNode(rtv_Permissions.Nodes, false);
        }
    }
}