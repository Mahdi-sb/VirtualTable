using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validation.AddValueToDB
{
   public class CheckValue : ICheckValue
    {
        IValidation _valid;
        public CheckValue(IValidation valid)
        {
            _valid = valid;
        }
        public string CheckBool(List<(int id, string fieldvalue, string column, string type)> values)
        {
            foreach (var item in values)
            {

                if (item.type == "BOOL" && (item.fieldvalue.ToLower() != "true" && item.fieldvalue.ToLower() != "false"))
                {
                    return _valid.IsBool();
                }


            }
            return _valid.IsOk();
        }

        public string CheckInt(List<(int id, string fieldvalue, string column, string type)> values)
        {
            foreach (var item in values)
            {
                if (item.type == "INT" && item.fieldvalue.Any(char.IsLetter))
                {
                    return _valid.IsInt();

                }

            }
            return _valid.IsOk();
        }

        public string CheckString(List<(int id, string fieldvalue, string column, string type)> values)
        {
            foreach (var item in values)
            {
                if (item.type == "STRING" && item.fieldvalue.All(char.IsDigit))
                {
                    return _valid.IsString();
                }
            }
            return _valid.IsOk();
        }

        public string CheckValues(List<(int id, string fieldvalue, string column, string type)> values)
        {
            if (CheckString(values) != "ok") return CheckString(values);
            if (CheckInt(values) != "ok") return CheckInt(values);
            if (CheckBool(values) != "ok") return CheckBool(values);
            return _valid.IsOk();
        }
    }
}
