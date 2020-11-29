using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Context
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AppDBContext _Context;
        private readonly DbSet<TEntity> _dbset;

        public Repository(AppDBContext context)
        {
            _Context = context;
            _dbset =_Context.Set<TEntity>();
        }

        public bool FindValue(Expression<Func<TEntity, bool>> where)
        {
            return _dbset.Where(where).ToList().Count > 0 ? true : false;
            

            
        }

        public int GetIdOfTable(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity,int>> select)
        {
            return _dbset.Where(where).Select(select).FirstOrDefault();
        }

        public List<TEntity> GetAll()
        {
            return _dbset.ToList();
        }

        public void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public List<TEntity> TableColumn(Expression<Func<TEntity, bool>> where)
        {

            return _dbset.Where(where).ToList();

        }

        public List<string> AllType(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, string>> select)
        {
            return _dbset.Where(where).Select(select).ToList();
            
        }
    }
}
