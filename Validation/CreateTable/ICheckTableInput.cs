using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
   public interface ICheckTableInput 
    {
        public string ColumnName(List<TypesDTO> Types);
        public string NumberOfColumn(List<TypesDTO> Types);
        public string CheckTableName(string TableName);
        public string CheckAllinput(List<TypesDTO> Types, string TableName);




    }
}
