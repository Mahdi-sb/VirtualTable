using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TypesDTO
    {
        public TypesDTO()
        {

        }
        public TypesDTO(string name, string type)
        {
            Field_Name = name;
            Field_Type = type;
        }
        public TypesDTO(int id,string name,string type , string value )
        {
            TableId = id;
            Field_Name = name;
            Field_Type = type;
            Value = value;
        }
        public string Value { get; set; }
        public int TableId { get; set; }
        public string Field_Name { get; set; }
        public string Field_Type { get; set; }
    }
}
