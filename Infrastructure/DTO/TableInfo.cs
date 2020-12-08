using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DTO
{
    public class TableInfo
    {
        public string TableName { get; set; }
        public List<Types> Type { get; set; }

        public class Types
        {
            public string ColumnName { get; set; }
            public string Type { get; set; }
        }
    }
}
