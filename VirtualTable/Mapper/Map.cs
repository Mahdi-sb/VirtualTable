using Infrastructure.DTO;
using System.Collections.Generic;
using System.Linq;
using Models;
using VirtualTable.ViewModel;
using Infrastructure.Enum;

namespace VirtualTable.Mapper
{
   public static class Map 
    {
        public static List<TableDto> TableList(List<Tables> tables)
        {
            return tables.Select(item => new TableDto(item.Id, item.TableName)).ToList();
        }

        public static List<TypesDto> TypeList(List<Types> types)
        {
            return types.Select(item => new TypesDto(item.TableId, item.FieldName, item.FieldType, null)).ToList();
        }

        public static List<TypesDto> TypeList(TableView table)
        {
            return table.TypeList.Select(item => new TypesDto(item.ColumnName, item.Type)).ToList();
        }

        public static List<ValueDto> ValueList(List<Value> values)
        {
            return values.Select(item => new ValueDto(item.Id, item.FieldValue, item.Column)).ToList();
        }

        public static List<TypesDto> TypeList(List<ValueDto> values)
        {
            return values.Select(item => new TypesDto(item.TableId, item.Column, item.Type, item.FieldValue)).ToList();
        }
        public static List<TypesDto> TypeList(TableInfo table)
        {
            return table.Type.Select(item => new TypesDto(item.ColumnName, FindType(item.Type))).ToList();
        }

        private static ColumnTypes FindType(string type)
        {
            return type.ToLower() switch
            {
                "bool" => ColumnTypes.BOOL,
                "string" => ColumnTypes.STRING,
                _ => ColumnTypes.INT
            };
        }
    }
}
