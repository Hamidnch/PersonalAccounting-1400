//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using PersonalAccounting.Domain.Entity;

//namespace PersonalAccounting.DAL.Repository
//{
//    public interface IRepository<T> : IEnumerable<object> where T : BaseEntity
//    {
//        IQueryable<T> GetAll();
//        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
//            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
//        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
//        IQueryable<T> FindBy<TKey>(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50);
//        bool Contains(Expression<Func<T, bool>> predicate);
//        T Find(params object[] keys);
//        T Find(Expression<Func<T, bool>> predicate);
//        IQueryable<T> Where(Expression<Func<T, bool>> expression);
//        IQueryable<T> OrderBy(Expression<Func<T, string>> expression);
//        T Add(T entity);
//        int Delete(T entity);
//        int Delete(Expression<Func<T, bool>> predicate);
//        int Update(T entity);
//        int Count<TEntity>() where TEntity : BaseEntity;
//    }
//}
