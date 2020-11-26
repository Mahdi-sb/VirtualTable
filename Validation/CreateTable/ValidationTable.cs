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

        public string CheckAllinput(List<Tuple<string, string>> Types, string TableName)
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

        public string ColumnName(List<Tuple<string, string>> Types)
        {
            var name = " ";
            foreach (var item in Types)
            {
                
                if(item.Item2 == name)
                {
                    return _valid.RepetitiveColumnName();
                }
                name = item.Item2;
            }
            return _valid.IsOk();
        }

        public string NumberOfColumn(List<Tuple<string, string>> Types)
        {
            return Types.Count == 0 ? _valid.AddColumn() : _valid.IsOk();
        }
    }
}
