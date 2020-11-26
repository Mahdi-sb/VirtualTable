using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entity
{
    public class Value
    {
        public int Id { get; set; }
        [Required]
        public int TableId { get; set; }
        [Required]
        public string Column { get; set; }
        [Required]
        public string FieldValue { get; set; }
    }
}
