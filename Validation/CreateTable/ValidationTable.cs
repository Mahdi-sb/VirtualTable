using Repository.Context;
using System;
using System.Collections.Generic;

namespace Validation
{
    public class ValidationTable : ICheckTableInput
    {
        IValidation _valid;
        IUnitOfWork _db;
        public ValidationTable(IValidation valid , IUnitOfWork db)
        {
            _valid = valid;
            _db = db;
        }

        public string CheckAllinput(List<(string type, string columnName)> Types, string TableName)
        {
            if (CheckTableName(TableName) != "ok") return CheckTableName(TableName);
            if (ColumnName(Types) != "ok") return ColumnName(Types);
            if (NumberOfColumn(Types) != "ok") return NumberOfColumn(Types);
            return _valid.IsOk();

        }

        public string CheckTableName(string TableName)
        {
            return _db.Tables.FindValue(x => x.TableName == TableName) ?
            _valid.RepetitiveTableName (): _valid.IsOk();
        }

        public string ColumnName(List<(string type, string columnName)> Types)
        {
            var name = " ";
            foreach (var item in Types)
            {
                
                if(item.columnName == name)
                {
                    return _valid.RepetitiveColumnName();
                }
                name = item.columnName;
            }
            return _valid.IsOk();
        }

        public string NumberOfColumn(List<(string type, string columnName)> Types)
        {
            return Types.Count == 0 ? _valid.AddColumn() : _valid.IsOk();
        }
    }
}
