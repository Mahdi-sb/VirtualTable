﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public class TableDTO
    {
        public TableDTO()
        {

        }
        public TableDTO(int id,string name)
        {
            Id = id;
            TableName = name;
        }
        public int Id { get; set; }

        public string TableName { get; set; }
    }
}
