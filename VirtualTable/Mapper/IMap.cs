using Infrastructure.DTO;
using Models.Entity;
using System.Collections.Generic;
using VirtualTable.ViewModel;

namespace VirtualTable.Mapper
{
    public interface IMap
    {
        List<TableDTO> TableList(List<Tables> tables);
        List<TypesDTO> TypeList(List<Types> types);
        List<TypesDTO> TypeList (List<ValueDTO> values);
        List<ValueDTO> ValueList(List<Value> values);
        List<TypesDTO> TypeList(TableView table);

    }
}
