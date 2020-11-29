using Infrastructure.DTO;
using System.Collections.Generic;

namespace Service.AddNewTable
{
    public interface IAddTable
    {
        /// <summary>
        /// Add Value to Tables Table in Database
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="model"></param>
        void AddToTables(string model);
        /// <summary>
        /// Add value to Type Table in Database
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="Id"></param>
        void AddToType(List<TypesDTO> Types, int Id);

        /// <summary>
        /// Add value to CreateTime Table in Database
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="model"></param>
        /// <param name="Id"></param>
        void AddToTime(int Id);

        string AddInformationTodatabase(string TableName,List<TypesDTO> Types);
    }
}
