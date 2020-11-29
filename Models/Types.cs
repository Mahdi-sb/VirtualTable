using Infrastructure.Enum;

namespace Models.Entity
{
    public class Types
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public string Field_Name { get; set; }
        public ColumnTypes Field_Type { get; set; }

    }
}
