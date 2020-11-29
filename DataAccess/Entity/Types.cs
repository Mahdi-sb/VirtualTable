using DTO.Enum;

namespace DataAccess.Entity
{
    public class Types
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public string Field_Name { get; set; }
        public ColumnTypes Field_Type { get; set; }

    }
}
