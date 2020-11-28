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
        public string AddInformationTodatabase(string TableName, List<(string type, string columnName)> Types)
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


        public void AddToType(List<(string type, string columnName)> Types, int Id)
        {
            foreach (var item in Types)
            {
                _db.Types.Insert(new Types { Field_Name = item.columnName, Field_Type = item.type, TableId = Id });
            }
        }

        int getid(string name)
        {
            return _db.Tables.GetIdOfTable(x => x.TableName == name, x => x.Id);
        }
    }
}
