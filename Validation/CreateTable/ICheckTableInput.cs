using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
   public interface ICheckTableInput 
    {
        public string ColumnName(List<Tuple<string, string>> Types);
        public string NumberOfColumn(List<Tuple<string,string>> Types);
        public string CheckTableName(string TableName);
        public string CheckAllinput(List<Tuple<string, string>> Types, string TableName);




    }
}
