using Infrastructure.DTO;
using Models.Entity;
using System.Collections.Generic;
using VirtualTable.ViewModel;

namespace VirtualTable.Mapper
{
    public class Map : IMap
    {
        public List<TableDTO> TableList(List<Tables> tables)
        {
            List<TableDTO> list = new List<TableDTO>();
            foreach (var item in tables)
            {
                list.Add(new TableDTO(item.Id, item.TableName));
            }
            return list;
        }

        public List<TypesDTO> TypeList(List<Types> types)
        {
            List<TypesDTO> list = new List<TypesDTO>();
            foreach (var item in types)
            {
                list.Add(new TypesDTO(item.TableId, item.Field_Name, item.Field_Type, null));
            }
            return list;
        }

        public List<TypesDTO> TypeList(TableView table)
        {
            List<TypesDTO> list = new List<TypesDTO>();
            foreach (var item in table.TypeList)
            {
                list.Add(new TypesDTO(item.ColumnName, item.Type));
            }
            return list;
        }

        public List<ValueDTO> ValueList(List<Value> values)
        {
            List<ValueDTO> list = new List<ValueDTO>();
            foreach (var item in values)
            {
                list.Add(new ValueDTO(item.Id, item.FieldValue, item.Column));

            }
            return list;
        }

        public List<TypesDTO> TypeList(List<ValueDTO> values)
        {
            List<TypesDTO> list = new List<TypesDTO>();
            foreach (var item in values)
            {
                list.Add(new TypesDTO(item.TableId, item.Column, item.Type, item.FieldValue));

            }
            return list;
        }
    }
}
