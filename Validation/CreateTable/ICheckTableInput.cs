using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
   public interface ICheckTableInput 
    {
        public string ColumnName(List<(string type, string columnName)> Types);
        public string NumberOfColumn(List<(string type, string columnName)> Types);
        public string CheckTableName(string TableName);
        public string CheckAllinput(List<(string type, string columnName)> Types, string TableName);




    }
}
