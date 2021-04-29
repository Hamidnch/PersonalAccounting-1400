using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.UI.Infrastructure;

namespace PersonalAccounting.UI
{
    public partial class FrmExpenseReport : BaseForm
    {
        private readonly IExpenseService _expenseService;

        public static FrmExpenseReport AFrmExpenseReport = null;
        public static FrmExpenseReport Instance()
        {
            return AFrmExpenseReport ?? (AFrmExpenseReport = IocConfig.Container.GetInstance<FrmExpenseReport>());
        }
        public FrmExpenseReport(IExpenseService expenseService)
        {
            _expenseService = expenseService;
            InitializeComponent();

            BindGrid();
        }

        private void BindGrid()
        {
            //int? currentUserId = null;
            //if (!await InitialHelper.CurrentUser.IsAdmin())
            //int? currentUserId = InitialHelper.CurrentUser.Id;

            rgv_Expenses.BeginUpdate();
            rgv_Expenses.DataSource = _expenseService.LoadAllExpenses();
            rgv_Expenses.EndUpdate();
        }
    }
}
