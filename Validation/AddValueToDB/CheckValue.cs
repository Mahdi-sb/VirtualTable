using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validation.AddValueToDB
{
   public class CheckValue : ICheckValue
    {
        
        public string CheckBool(List<ValueDTO> values)
        {
            foreach (var item in values)
            {

                if (item.Type == "BOOL" && (item.FieldValue.ToLower() != "true" && item.FieldValue.ToLower() != "false"))
                {
                    return Validation.IsBool;
                }


            }
            return Validation.IsOk;
        }

        public string CheckInt(List<ValueDTO> values)
        {
            foreach (var item in values)
            {
                if (item.Type == "INT" && item.FieldValue.Any(char.IsLetter))
                {
                    return Validation.IsInt;

                }

            }
            return Validation.IsOk;
        }

        public string CheckString(List<ValueDTO> values)
        {
            foreach (var item in values)
            {
                if (item.Type == "STRING" && item.FieldValue.All(char.IsDigit))
                {
                    return Validation.IsString;
                }
            }
            return Validation.IsOk;
        }

        public string CheckValues(List<ValueDTO> values)
        {
            if (CheckString(values) != "ok") return CheckString(values);
            if (CheckInt(values) != "ok") return CheckInt(values);
            if (CheckBool(values) != "ok") return CheckBool(values);
            return Validation.IsOk;
        }
    }
}
