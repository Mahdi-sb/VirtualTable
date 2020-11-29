using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO
{
    public class ValueDTO
    {
        public ValueDTO()
        {

        }
        public ValueDTO(int id,string name, string column)
        {
            TableId = id;
            Column = column;
            FieldValue = name;

        }
        [Required]
        public int TableId { get; set; }
        [Required]
        public string Column { get; set; }
        [Required(ErrorMessage = " وارد شود")]
        public string FieldValue { get; set; }
        public string Type { get; set; }


    }
}
