using Infrastructure;
using Infrastructure.DTO;
using Infrastructure.Enum;
using System.Collections.Generic;
using System.Linq;

namespace Validation.AddValueToDB
{
    public class CheckValue : ICheckValue
    {
        
        public string CheckBool(List<ValueDTO> values)
        {
            foreach (var item in values)
            {

                if (item.Type == ColumnTypes.BOOL && (item.FieldValue.ToLower() != "true" && item.FieldValue.ToLower() != "false"))
                {
                    return Massage.IsBool;
                }


            }
            return Massage.IsOk;
        }

        public string CheckInt(List<ValueDTO> values)
        {
            foreach (var item in values)
            {
                if (item.Type == ColumnTypes.INT && item.FieldValue.Any(char.IsLetter))
                {
                    return Massage.IsInt;

                }

            }
            return Massage.IsOk;
        }

        public string CheckString(List<ValueDTO> values)
        {
            foreach (var item in values)
            {
                if (item.Type == ColumnTypes.STRING && item.FieldValue.All(char.IsDigit))
                {
                    return Massage.IsString;
                }
            }
            return Massage.IsOk;
        }

        public string CheckValues(List<ValueDTO> values)
        {
            if (CheckString(values) != "ok") return CheckString(values);
            if (CheckInt(values) != "ok") return CheckInt(values);
            if (CheckBool(values) != "ok") return CheckBool(values);
            return Massage.IsOk;
        }
    }
}
