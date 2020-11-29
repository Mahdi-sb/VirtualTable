﻿using Infrastructure;
using Infrastructure.DTO;
using Repository.Context;
using System.Collections.Generic;

namespace Validation.AddNewTable
{
    public class ValidationTable : ICheckTableInput
    {
        IUnitOfWork _db;
        public ValidationTable( IUnitOfWork db)
        {
            _db = db;
        }

        public string CheckAllinput(List<TypesDTO> Types, string TableName)
        {
            if (CheckTableName(TableName) != "ok") return CheckTableName(TableName);
            if (ColumnName(Types) != "ok") return ColumnName(Types);
            if (NumberOfColumn(Types) != "ok") return NumberOfColumn(Types);
            return Massage.IsOk;

        }

        public string CheckTableName(string TableName)
        {
            return _db.Tables.FindValue(x => x.TableName == TableName) ?
            Massage.RepetitiveTableName : Massage.IsOk;
        }

        public string ColumnName(List<TypesDTO> Types)
        {
            var name = " ";
            foreach (var item in Types)
            {
                
                if(item.Field_Name == name)
                {
                    return Massage.RepetitiveColumnName;
                }
                name = item.Field_Name;
            }
            return Massage.IsOk;
        }

        public string NumberOfColumn(List<TypesDTO> Types)
        {
            return Types.Count == 0 ? Massage.AddColumn : Massage.IsOk;
        }
    }
}