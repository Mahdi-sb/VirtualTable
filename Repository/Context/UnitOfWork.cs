using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        public UnitOfWork(AppDBContext context)
        {
            _context = context;
        }

        Repository<Types> _types;

        public IRepository<Types> Types
        {
            get
            {
                return _types ??
                    (_types = new Repository<Types>(_context));    
            }
        }

        Repository<Value> _Value;
        public IRepository<Value> Value
        {
            get
            {
                return _Value ??
                    (_Value = new Repository<Value>(_context));
            }
        }

        Repository<CreateTime> _time;
        public IRepository<CreateTime> Times
        {
            get
            {
                return _time ??
                    (_time = new Repository<CreateTime>(_context));
            }
        }

        Repository<Tables> _Table;
        public IRepository<Tables> Tables
        {
            get
            {
                return _Table ??
                    (_Table = new Repository<Tables>(_context));
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
