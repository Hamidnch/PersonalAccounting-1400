//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Data.Entity;
//using System.Linq;
//using System.Linq.Expressions;
//using MessageBoxHamidNCH;
//using PersonalAccounting.CommonLibrary.Helper;
//using PersonalAccounting.DAL.Infrastructure;
//using PersonalAccounting.Domain.Entity;

//namespace PersonalAccounting.DAL.Repository
//{
//    public class Repository<T> : IRepository<T> where T : BaseEntity
//    {
//        private readonly PersonalAccountingContext _context;
//        private readonly IDbSet<T> _dbSet;

//        public Repository()
//        {
//            _context = new PersonalAccountingContext();
//            _dbSet = _context.Set<T>();
//        }
//        public Repository(PersonalAccountingContext context)
//        {
//            _context = context;
//            _dbSet = _context.Set<T>();
//        }
//        public virtual IQueryable<T> GetAll()
//        {
//          return _dbSet.AsQueryable(); //this._context.Set<T>();
//        }
//        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
//                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
//        {
//            IQueryable<T> query = _dbSet;

//            if (filter != null)
//            {
//                query = query.Where(filter);
//            }
//            //foreach (var includeProperty in includeProperties.Split
//            //    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
//            query = includeProperties.Split(new char[] { ',' },
//                StringSplitOptions.RemoveEmptyEntries).Aggregate(query,
//                (current, includeProperty) => current.Include(includeProperty));

//            if (orderBy != null)
//            {
//                return orderBy(query).ToList();
//            }
//            else
//            {
//                return query.ToList();
//            }
//        }
//        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
//        {
//            return _dbSet.Where(predicate).AsQueryable<T>(); //this._context.Set<T>().Where(predicate);
//        }
//        public virtual IQueryable<T> FindBy<TKey>(Expression<Func<T, bool>> filter,
//                                                out int total, int index = 0, int size = 50)
//        {
//            var skipCount = index * size;
//            var resetSet = filter != null
//                ? _dbSet.Where(filter).AsQueryable()
//                : _dbSet.AsQueryable();
//            resetSet = skipCount == 0
//                ? resetSet.Take(size)
//                : resetSet.Skip(skipCount).Take(size);
//            total = resetSet.Count();
//            return resetSet.AsQueryable();
//        }
//        public virtual bool Contains(Expression<Func<T, bool>> predicate)
//        {
//            return _dbSet.Count(predicate) > 0;
//        }
//        public virtual T Find(params object[] keys)
//        {
//            return _dbSet.Find(keys);
//        }
//        public virtual T Find(Expression<Func<T, bool>> predicate)
//        {
//            return _dbSet.Where(predicate).FirstOrDefault<T>();
//        }
//        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
//        {
//            return _dbSet.Where(expression);
//        }
//        public IQueryable<T> OrderBy(Expression<Func<T, string>> expression)
//        {
//            return _dbSet.OrderBy(expression);
//        }
//        public virtual T Add(T entity)
//        {
//            //_context.Entry(entity).State = EntityState.Added;
//            //_dbSet.Attach(entity);
//            var newEntry = _dbSet.Add(entity);
//            //  if (!_shareContext)
//            _context.SaveChanges();
//            return newEntry;
//        }
//        public virtual int Delete(T entity)
//        {
//            _dbSet.Remove(entity);
//            return _context.SaveChanges();
//        }

//        public virtual int Delete(Expression<Func<T, bool>> predicate)
//        {
//            var ret = -1;
//            try
//            {
//                var objects = FindBy(predicate);
//                foreach (var obj in objects)
//                    _dbSet.Remove(obj);
//                ret = _context.SaveChanges();
//            }
//            catch (Exception ex)
//            {
//                var dlg = new CustomDialogs(400, 200);
//                dlg.Invoke("وقوع خطا", ex.ExceptionToString() /*ex.InnerException.InnerException.Message*/, CustomDialogs.ImageType.itError4,
//                    CustomDialogs.ButtonType.Ok);
//            }
//            return ret;
//        }

//        private int GetPrimaryKey(T entity)
//        {
//            var myObject = _context.Entry(entity);
//            var property =
//                myObject.GetType()
//                     .GetProperties().FirstOrDefault(prop => Attribute.IsDefined(prop, typeof(KeyAttribute)));
//            return (int)property.GetValue(myObject, null);
//        }

//        public virtual int Update(T entity)
//        {
//            try
//            {
//                var entry = _context.Entry(entity);

//                if (entry.State == EntityState.Detached)
//                {
//                    var currentEntry = _dbSet.Find(entity.Id);
//                    if (currentEntry != null)
//                    {
//                        var attachedEntry = _context.Entry(currentEntry);
//                        attachedEntry.CurrentValues.SetValues(entity);
//                    }
//                    else
//                    {
//                        _dbSet.Attach(entity);
//                        entry.State = EntityState.Modified;
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                var dlg = new CustomDialogs(400, 200);
//                dlg.Invoke("وقوع خطا", ex.ExceptionToString(), CustomDialogs.ImageType.itError4,
//                    CustomDialogs.ButtonType.Ok);
//            }
//            //entry.State = EntityState.Modified;
//            return _context.SaveChanges();
//        }

//        public int Count<TEntity>() where TEntity : BaseEntity
//        {
//            return _dbSet.Count();
//        }
//        //public int Count<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : BaseEntity
//        //{
//        //    return _dbSet.Count(predicate);
//        //}
//        public IEnumerator<object> GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//    }
//}
