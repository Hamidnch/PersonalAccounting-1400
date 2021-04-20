using PersonalAccounting.BLL.Enum;
using PersonalAccounting.BLL.IService;
using PersonalAccounting.CommonLibrary.Helper;
using PersonalAccounting.DAL.Infrastructure;
using PersonalAccounting.Domain.Entity;
using PersonalAccounting.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccounting.BLL.Service
{
    //public static class LocalFunction
    //{
    //    public static string ListToString(this ICollection<Role> roles)
    //    {
    //        var res = roles.Aggregate(string.Empty, (current, role) => current + (role.Name + ", "));
    //        res = res.Substring(0, res.Length - 2);
    //        return res;
    //    }
    //}
    public class UserService : BaseService, IUserService
    {
        private const string Active = "فعال";
        public int MaxInvalidPasswordAttempts { get; set; } = 3;

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<User> _users;
        private readonly IDbSet<Role> _roles;

        private const string EntityName = nameof(User);
        private const string EntityNameNormal = "کاربری";

        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _users = _unitOfWork.Set<User>();
            _roles = _unitOfWork.Set<Role>();
        }

        public async Task<int> CountAsync()
        {
            return await _users.AsNoTracking().CountAsync();
        }

        public async Task<IList<User>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _users.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _users.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllUser>> LoadAllViewModelAsync(int? createdBy)
        {
            if (createdBy != null)
            {
                var myQuery =
                    from usr in _users.AsNoTracking().Where(a => a.CreatedBy == createdBy)
                    select new ViewModelLoadAllUser()
                    {
                        UserId = usr.Id,
                        PersonId = usr.Person.Id,
                        PersonName = usr.Person.FullName,
                        UserName = usr.UserName,
                        Password = usr.Password,
                        Email = usr.Email,
                        CreationDate = usr.CreatedOn,
                        LastUpdate = usr.LastUpdate,
                        CreationUser = usr.SelfUser.UserName,
                        UpdateByUser = usr.UpdateUser.UserName,
                        Description = usr.Description,
                        Ip = usr.Ip,
                        IsApproved = usr.IsApproved,//(usr.IsApproved ? "تایید" : "رد"),
                        IsLockout = usr.IsLockout,//(usr.IsLockout ? "محروم" : "مجاز"),
                        LastActivityDate = usr.LastActivityDate,
                        LastLockoutDate = usr.LastLockoutDate,
                        LastLoginDate = usr.LastLoginDate,
                        LastPasswordChangedDate = usr.LastPasswordChangedDate,
                        LastPasswordFailureDate = usr.LastPasswordFailureDate,
                        LoginCount = usr.LoginCount,
                        PasswordFailuresSinceLastSuccess = usr.PasswordFailuresSinceLastSuccess,
                        Status = usr.Status,
                        Roles = usr.Roles
                    };

                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from usr in _users.AsNoTracking()//.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllUser()
                    {
                        UserId = usr.Id,
                        PersonId = usr.Person.Id,
                        PersonName = usr.Person.FullName,
                        UserName = usr.UserName,
                        Password = usr.Password,
                        Email = usr.Email,
                        CreationDate = usr.CreatedOn,
                        LastUpdate = usr.LastUpdate,
                        CreationUser = usr.SelfUser.UserName,
                        UpdateByUser = usr.UpdateUser.UserName,
                        Description = usr.Description,
                        Ip = usr.Ip,
                        IsApproved = usr.IsApproved,//(usr.IsApproved ? "تایید" : "رد"),
                        IsLockout = usr.IsLockout,//(usr.IsLockout ? "محروم" : "مجاز"),
                        LastActivityDate = usr.LastActivityDate,
                        LastLockoutDate = usr.LastLockoutDate,
                        LastLoginDate = usr.LastLoginDate,
                        LastPasswordChangedDate = usr.LastPasswordChangedDate,
                        LastPasswordFailureDate = usr.LastPasswordFailureDate,
                        LoginCount = usr.LoginCount,
                        PasswordFailuresSinceLastSuccess = usr.PasswordFailuresSinceLastSuccess,
                        Status = usr.Status,
                        Roles = usr.Roles
                    };

                return await myQuery.ToListAsync();
            }
        }

        public async Task<IList<ViewModelSimpleLoadUser>> SimpleLoadViewModelAsync()
        {
            var query =
                from usr in _users.AsNoTracking()//.Where(a => a.Status == "فعال")
                select new ViewModelSimpleLoadUser()
                {
                    UserId = usr.Id,
                    UserName = usr.UserName
                };
            return await query.ToListAsync();
        }

        public async Task<UserRegisterStatus> CreateAsync(User newUser)
        {
            try
            {
                if (await ExistAsync(newUser.UserName))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return UserRegisterStatus.UserNameExist;
                }
                if (await ExistAsync(newUser.Email))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return UserRegisterStatus.EmailExist;
                }

                _users.Add(newUser);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {newUser.UserName} با موفقیت ایجاد گردید.");
                return UserRegisterStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return UserRegisterStatus.Failure;
            }
        }

        public async Task<UserRegisterStatus> UpdateAsync(User user)
        {
            //if (await ExistAsync(user.UserName))
            //    return UserRegisterStatus.UserNameExist;
            //if (await ExistAsync(user.Email)) return UserRegisterStatus.EmailExist;

            _users.AddOrUpdate(user);
            //_unitOfWork.MarkAsChanged(user);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {user.UserName} با موفقیت ویرایش گردید.");
            return UserRegisterStatus.Successful;
        }

        public async Task<User> GetByIdAsync(int userId)
        {
            return await _users.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<User> GetByUsernameAsync(string userName)
        {
            return await _users.AsNoTracking().FirstOrDefaultAsync(u => u.UserName == userName);
        }
        public async Task<IList<User>> GetUsersByRoleAsync(Role role)
        {
            return await _users.Include(u => u.Roles
                .Where(r => r.Id == role.Id && r.Name == role.Name)).ToListAsync();
        }

        public async Task<IList<User>> GetUsersByRoleAsync(string roleName)
        {
            // var users = await Users.AnyAsync(u => u.Roles.Any(r => r.Name == roleName));
            return await
                _users.Where(u => u.Roles.Any(r => r.Name == roleName)).ToListAsync();
        }
        public async Task<ValidateStatus> ValidateAsync(string userName, string password)
        {
            var status = new ValidateStatus();
            if (string.IsNullOrEmpty(userName))
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), "نام کاربری نمی تواند نال باشد");
                status.ValidateUserStatus = ValidateUserStatus.UsernameIsEmpty;
                return status;
            }
            if (string.IsNullOrEmpty(password))
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), "کلمه عبور نمی تواند نال باشد");
                status.ValidateUserStatus = ValidateUserStatus.PasswordIsEmpty;
                return status;
            }

            var user = await GetByUsernameAsync(userName);

            if (user == null)
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $" با نام {userName} وجود ندارد.");
                status.ValidateUserStatus = ValidateUserStatus.UserIsNotExists;
                return status;
            }

            if (user.Status != Active)
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $" با نام {userName} فعال نمی باشد.");
                status.ValidateUserStatus = ValidateUserStatus.IsNotActive;
                return status;
            }

            if (!user.IsApproved)
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $" با نام {userName} تایید نمی باشد.");
                status.ValidateUserStatus = ValidateUserStatus.IsNotApproved;
                return status;
            }

            if (user.IsLockout)
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $" با نام {userName} قفل می باشد.");
                status.ValidateUserStatus = ValidateUserStatus.IsLockout;
                return status;
            }

            var failures = user.PasswordFailuresSinceLastSuccess;
            if (failures < MaxInvalidPasswordAttempts)
            {
                user.PasswordFailuresSinceLastSuccess += 1;
                user.LastPasswordFailureDate = DateTime.Now;

                _users.AddOrUpdate(user);
                //_unitOfWork.MarkAsChanged(user);
                await _unitOfWork.SaveChangesAsync();

                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $"با نام کاربری {userName} به تعداد {user.PasswordFailuresSinceLastSuccess}" +
                                                    $" بار در تاریخ {user.LastPasswordFailureDate}" +
                                                    "  تلاش غیرموفق برای وردو داشته است. ");
            }
            else if (failures >= MaxInvalidPasswordAttempts)
            {
                user.LastPasswordFailureDate = DateTime.Now;
                user.LastLockoutDate = DateTime.Now;
                user.IsLockout = true;

                _users.AddOrUpdate(user);
                //_unitOfWork.MarkAsChanged(user);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal +
                                                    $"با نام کاربری {userName} به دلیل تلاش بیش از اندازه برای ورود قفل شد.");

                status.ValidateUserStatus = ValidateUserStatus.IsLockout;
                return status;
            }

            var hashedPassword = user.Password;
            var verificationSucceeded = (hashedPassword != null &&
                                Utility.VerifyHashedPassword(hashedPassword, password));

            if (!verificationSucceeded)
            {
                InsertLog(LogLevel.Information, EntityName,
                    "ValidateAsync", GetServiceName(),
                    $"کلمه عبور وارده با مقدار {hashedPassword} برای نام کاربری {userName} اشتباه است.");
                status.ValidateUserStatus = ValidateUserStatus.Failure;
                return status;
            }

            user.PasswordFailuresSinceLastSuccess = 0;
            user.PreviousLastLoginDate = user.LastLoginDate;
            if (user.PreviousLastLoginDate.HasValue && user.LastActivityDate.HasValue)
            {
                var x = user.LastActivityDate.Value;
                var dateDiff = user.LastActivityDate.Value.Subtract(
                    user.PreviousLastLoginDate.Value);
                //user.LastActiveDuration = dateDiff;
                user.LastActiveDurationValue = Math.Abs(dateDiff.Ticks);
            }

            user.LastLoginDate = DateTime.Now;
            user.LoginCount += 1;

            _users.AddOrUpdate(user);
            //_unitOfWork.MarkAsChanged(user);
            await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Warning, EntityName,
                "ValidateAsync", GetServiceName(), EntityNameNormal
                                                + $" با نام کاربری {userName} "
                                                + $" در تاریخ {user.LastLoginDate} " +
                                                " موفق به ورود به سیستم شد. "
                                                + $" تعداد لاگین تاکنون {user.LoginCount} مرتبه می باشد.");

            status.CurrentUser = user;
            status.ValidateUserStatus = ValidateUserStatus.Successful;
            return status;
        }

        public async Task<ValidateStatus> ValidateAsync(User currentUser)
        {
            var status = new ValidateStatus();
            if (string.IsNullOrEmpty(currentUser.UserName))
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), "نام کاربری نمی تواند نال باشد");
                status.ValidateUserStatus = ValidateUserStatus.UsernameIsEmpty;
                return status;
            }
            if (string.IsNullOrEmpty(currentUser.Password))
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), "کلمه عبور نمی تواند نال باشد");
                status.ValidateUserStatus = ValidateUserStatus.PasswordIsEmpty;
                return status;
            }

            //var user = await _users.FirstOrDefaultAsync(usr => usr.UserName == currentUser.UserName);
            var user = await GetByUsernameAsync(currentUser.UserName);

            if (user == null)
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $" با نام {currentUser.UserName} وجود ندارد.");
                status.ValidateUserStatus = ValidateUserStatus.UserIsNotExists;
                return status;
            }

            if (user.Status != Active)
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $" با نام {currentUser.UserName} فعال نمی باشد.");
                status.ValidateUserStatus = ValidateUserStatus.IsNotActive;
                return status;
            }

            if (!user.IsApproved)
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $" با نام {currentUser.UserName} تایید نمی باشد.");
                status.ValidateUserStatus = ValidateUserStatus.IsNotApproved;
                return status;
            }

            if (user.IsLockout)
            {
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $" با نام {currentUser.UserName} قفل می باشد.");
                status.ValidateUserStatus = ValidateUserStatus.IsLockout;
                return status;
            }

            var failures = user.PasswordFailuresSinceLastSuccess;
            if (failures < MaxInvalidPasswordAttempts)
            {
                user.PasswordFailuresSinceLastSuccess += 1;
                user.LastPasswordFailureDate = DateTime.Now;

                _users.AddOrUpdate(user);
                //_unitOfWork.MarkAsChanged(user);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal + $"با نام کاربری {currentUser.UserName} به تعداد {user.PasswordFailuresSinceLastSuccess}" +
                                                    $" بار در تاریخ {user.LastPasswordFailureDate}" +
                                                    "  تلاش غیرموفق برای وردو داشته است. ");
            }
            else if (failures >= MaxInvalidPasswordAttempts)
            {
                user.LastPasswordFailureDate = DateTime.Now;
                user.LastLockoutDate = DateTime.Now;
                user.IsLockout = true;

                _users.AddOrUpdate(user);
                //_unitOfWork.MarkAsChanged(user);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Warning, EntityName,
                    "ValidateAsync", GetServiceName(), EntityNameNormal +
                                                    $"با نام کاربری {currentUser.UserName} به دلیل تلاش بیش از اندازه برای ورود قفل شد.");

                status.ValidateUserStatus = ValidateUserStatus.IsLockout;
                return status;
            }

            var hashedPassword = user.Password;
            var verificationSucceeded = (hashedPassword != null &&
                                Utility.VerifyHashedPassword(hashedPassword, currentUser.Password));

            if (!verificationSucceeded)
            {
                InsertLog(LogLevel.Information, EntityName,
                    "ValidateAsync", GetServiceName(),
                    $"کلمه عبور وارده با مقدار {hashedPassword} برای نام کاربری {currentUser.UserName} اشتباه است.");
                status.ValidateUserStatus = ValidateUserStatus.Failure;
                return status;
            }

            user.PasswordFailuresSinceLastSuccess = 0;
            user.PreviousLastLoginDate = user.LastLoginDate;
            if (user.PreviousLastLoginDate.HasValue && user.LastActivityDate.HasValue)
            {
                var x = user.LastActivityDate.Value;
                var dateDiff = user.LastActivityDate.Value.Subtract(
                    user.PreviousLastLoginDate.Value);
                //user.LastActiveDuration = dateDiff;
                user.LastActiveDurationValue = Math.Abs(dateDiff.Ticks);
            }

            user.LastLoginDate = DateTime.Now;
            user.LoginCount += 1;

            _users.AddOrUpdate(user);
            //_unitOfWork.MarkAsChanged(user);
            await _unitOfWork.SaveChangesAsync();

            InsertLog(LogLevel.Warning, EntityName,
                "ValidateAsync", GetServiceName(), EntityNameNormal
                                                + $" با نام کاربری {currentUser.UserName} "
                                                + $" در تاریخ {user.LastLoginDate} " +
                                                " موفق به ورود به سیستم شد. "
                                                + $" تعداد لاگین تاکنون {user.LoginCount} مرتبه می باشد.");

            status.CurrentUser = user;
            status.ValidateUserStatus = ValidateUserStatus.Successful;
            return status;
        }

        public async Task<bool> ExistAsync(string userNameOrEmail)
        {
            if (string.IsNullOrEmpty(userNameOrEmail) || string.IsNullOrWhiteSpace(userNameOrEmail)) return false;

            return await _users.AnyAsync(f => f.UserName == userNameOrEmail || f.Email == userNameOrEmail);
        }

        public async Task<int> RemoveAsync(User user)
        {
            return await RemoveAsync(user.Id);

            //return await _users.Where(f => f.UserName == user.UserName || f.Email == user.Email).DeleteAsync();
        }

        public async Task<int> RemoveAsync(int userId)
        {
            var item = await _users.FirstOrDefaultAsync(f => f.Id == userId);
            _users.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            if (!(item is null))
                InsertLog(LogLevel.Information, EntityName,
                    "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.UserName} با موفقیت حذف گردید.");
            return res;
        }

        //public async Task<bool> AssignToUserAsync(User user, string roleName)
        //{
        //    var currentUser = await Users.FirstOrDefaultAsync(u => u.UserName == user.UserName);
        //    if (currentUser == null) return true;
        //    //var currentRole = new Role(roleName);
        //    //currentUser.Role = await GetByRoleNameAsync(user.UserName);
        //    var currentRole = await Roles.FirstOrDefaultAsync(r => r.Name == roleName);

        //    currentUser.Roles.Add(currentRole);
        //    _unitOfWork.MarkAsChanged(currentUser);
        //    await _unitOfWork.SaveChangesAsync();

        //    return true;
        //}

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _unitOfWork.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            //_unitOfWork?.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
