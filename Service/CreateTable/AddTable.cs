using DataAccess.Entity;
using Repository.Context;
using System;
using System.Collections.Generic;
using Validation;

namespace Service.CreateTable
{
    public class AddTable : IAddTable
    {
        IUnitOfWork _db;
        ICheckTableInput _check;
        public AddTable(IUnitOfWork db , ICheckTableInput check)
        {
            _db = db;
            _check = check;
        }
        public string AddInformationTodatabase(string TableName, List<Tuple<string, string>> Types)
        {
            if (_check.CheckAllinput(Types, TableName) != "ok") return _check.CheckAllinput(Types, TableName);
            AddToTables(TableName);
            AddToTime(getid(TableName));
            AddToType(Types, getid(TableName));
            _db.Save();
            return "ok";
        }


        public void AddToTables(string model)
        {

            _db.Tables.Insert(new Tables { TableName=model });
            _db.Save();

        }

        public void AddToTime(int Id)
        {
            _db.Times.Insert(new CreateTime { TableId = Id, Time = DateTime.Now });
        }


        public void AddToType(List<Tuple<string, string>> Types, int Id)
        {
            foreach (var item in Types)
            {
                _db.Types.Insert(new Types { Field_Name = item.Item2, Field_Type = item.Item1, TableId = Id });
            }
        }

        int getid(string name)
        {
            return _db.Tables.GetIdOfTable(x => x.TableName == name, x => x.Id);
        }
    }
}
