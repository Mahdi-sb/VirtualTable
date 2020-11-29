using Infrastructure.DTO;
using Models.Entity;
using System.Collections.Generic;

namespace Service.Addvalue
{
    public interface IAddValue
    {
        /// <summary>
        /// Add values to Value Table 
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="values"></param>
        string AddToValueTable(List<ValueDTO> values);

        /// <summary>
        /// return information of table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Types> TableData(int id);
        /// <summary>
        /// return all table name 
        /// </summary>
        /// <returns></returns>
        List<Tables> AllTable();

    }
}
