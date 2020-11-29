using Infrastructure.Enum;

namespace Infrastructure.DTO
{
    public class TypesDTO
    {
        public TypesDTO()
        {

        }
        public TypesDTO(string name, ColumnTypes type)
        {
            Field_Name = name;
            Field_Type = type;
        }
        public TypesDTO(int id,string name, ColumnTypes type , string value )
        {
            TableId = id;
            Field_Name = name;
            Field_Type = type;
            Value = value;
        }
        public string Value { get; set; }
        public int TableId { get; set; }
        public string Field_Name { get; set; }
        public ColumnTypes Field_Type { get; set; }
    }
}
