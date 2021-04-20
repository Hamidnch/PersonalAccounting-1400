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
    public class PersonService : BaseService, IRepositoryService<Person, ViewModelLoadAllPerson, ViewModelSimpleLoadPerson>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Person> _persons;
        private readonly IDbSet<User> _users;
        private readonly IDbSet<Expense> _expenses;

        private const string EntityName = nameof(Person);
        private const string EntityNameNormal = "شخص";

        public PersonService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _persons = _unitOfWork.Set<Person>();
            _users = _unitOfWork.Set<User>();
            _expenses = _unitOfWork.Set<Expense>();
        }

        public async Task<int> CountAsync()
        {
            return await _persons.AsNoTracking().CountAsync();
        }

        public async Task<IList<Person>> LoadAllAsync(bool containActives = true)
        {
            if (!containActives)
                return await _persons.Where(a => a.Status != "فعال")
                    .AsNoTracking().OrderByDescending(a => a.Id).ToListAsync();
            return await _persons.AsNoTracking().ToListAsync();
        }

        public async Task<IList<ViewModelLoadAllPerson>> LoadAllViewModelAsync(int? createdBy)
        {
            if (createdBy != null)
            {
                var myQuery =
                    from person in _persons.Where(a => a.CreatedBy == createdBy)
                    select new ViewModelLoadAllPerson()
                    {
                        PersonId = person.Id,
                        PersonFullName = person.FullName,
                        PersonLastUpdate = person.LastUpdate,
                        PersonCreationDate = person.CreatedOn,
                        PersonCreationUser = person.SelfUser.UserName,
                        PersonUpdateByUser = person.UpdateUser.UserName,
                        PersonDescription = person.Description,
                        PersonPicture = person.Picture,
                        PersonSex = person.Gender,
                        PersonStatus = person.Status
                    };
                return await myQuery.ToListAsync();
            }
            else
            {
                var myQuery =
                    from person in _persons
                        //.Where(a => a.Status == "فعال")
                    select new ViewModelLoadAllPerson()
                    {
                        PersonId = person.Id,
                        PersonFullName = person.FullName,
                        PersonLastUpdate = person.LastUpdate,
                        PersonCreationDate = person.CreatedOn,
                        PersonCreationUser = person.SelfUser.UserName,
                        PersonUpdateByUser = person.UpdateUser.UserName,
                        PersonDescription = person.Description,
                        PersonPicture = person.Picture,
                        PersonSex = person.Gender,
                        PersonStatus = person.Status
                    };
                return await myQuery.ToListAsync();
            }
        }

        public async Task<IList<ViewModelSimpleLoadPerson>> SimpleLoadViewModelAsync()
        {
            var myQuery = from person in _persons.AsNoTracking()
                          select new ViewModelSimpleLoadPerson()
                          {
                              PersonId = person.Id,
                              PersonName = person.FullName
                          };
            return await myQuery.ToListAsync();
        }

        public async Task<CreateStatus> CreateAsync(Person t)
        {
            try
            {
                if (await ExistAsync(t.FullName))
                {
                    InsertLog(LogLevel.Warning, EntityName,
                        "CreateAsync", GetServiceName(), EntityNameNormal + " جدید تکراری می باشد");
                    return CreateStatus.Exist;
                }

                _persons.Add(t);
                await _unitOfWork.SaveChangesAsync();
                InsertLog(LogLevel.Information, EntityName,
                    "CreateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.FullName} با موفقیت ثبت گردید.");
                return CreateStatus.Successful;
            }
            catch (Exception exception)
            {
                InsertLog(LogLevel.Error, EntityName,
                    "CreateAsync", exception.Message, exception.ToDetailedString());
                return CreateStatus.Failure;
            }
        }

        public async Task UpdateAsync(Person t)
        {
            _persons.AddOrUpdate(t);
            //_unitOfWork.MarkAsChanged(t);
            await _unitOfWork.SaveChangesAsync();
            InsertLog(LogLevel.Information, EntityName,
                "UpdateAsync", GetServiceName(), EntityNameNormal + $" جدید با نام {t.FullName} با موفقیت ویرایش گردید.");
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _persons.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Person> GetByNameAsync(string name)
        {
            return await _persons.AsNoTracking().FirstOrDefaultAsync(p => p.FullName == name);
        }

        public async Task<bool> ExistAsync(Person t)
        {
            return await _persons.AsNoTracking().AnyAsync(p => p.Id == t.Id && p.FullName == t.FullName);
        }

        public async Task<bool> IsUsedAsync(Person t)
        {
            return await IsUsedAsync(t.Id);
        }

        public async Task<bool> IsUsedAsync(int id)
        {
            return await _users.AnyAsync(e => e.PersonId == id) ||
                await _expenses.AnyAsync(e => e.ByPersonId == id || e.ForPersonId == id);
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _persons.AsNoTracking().AnyAsync(p => p.FullName == name);
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _persons.AsNoTracking().AnyAsync(p => p.Id == id);
        }

        public async Task<int> RemoveAsync(Person t)
        {
            return await RemoveAsync(t.Id);
        }

        public async Task<int> RemoveAsync(int id)
        {
            var item = await _persons.FirstOrDefaultAsync(f => f.Id == id);
            _persons.Remove(item);
            var res = await _unitOfWork.SaveChangesAsync();

            if (!(item is null))
                InsertLog(LogLevel.Information, EntityName,
                    "RemoveAsync", GetServiceName(), EntityNameNormal + $" با نام {item.FullName} با موفقیت حذف گردید.");

            return res;
        }

        public async Task<IList<ViewModelSimpleLoadPerson>> SimpleLoadViewModelOnlyNoneUserAsync()
        {
            var personIds = _users.Select(u => u.PersonId);
            var myQuery = from person in _persons.AsNoTracking()
                          where (!personIds.Contains(person.Id))
                          select new ViewModelSimpleLoadPerson()
                          {
                              PersonId = person.Id,
                              PersonName = person.FullName
                          };
            return await myQuery.ToListAsync();
        }


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
        public Task<IList<ViewModelLoadAllPerson>> GetByGroupIdAsync(int groupId)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            //_unitOfWork?.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}