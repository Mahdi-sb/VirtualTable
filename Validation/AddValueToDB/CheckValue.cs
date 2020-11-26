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
        public string CheckBool(List<Tuple<int, string, string, string>> values)
        {
            foreach (var item in values)
            {

                if (item.Item4 == "BOOL" && (item.Item2.ToLower() != "true" && item.Item2.ToLower() != "false"))
                {
                    return _valid.IsBool();
                }


            }
            return _valid.IsOk();
        }

        public string CheckInt(List<Tuple<int, string, string, string>> values)
        {
            foreach (var item in values)
            {
                if (item.Item4 == "INT" && item.Item2.Any(char.IsLetter))
                {
                    return _valid.IsInt();

                }

            }
            return _valid.IsOk();
        }

        public string CheckString(List<Tuple<int, string, string, string>> values)
        {
            foreach (var item in values)
            {
                if (item.Item4 == "STRING" && item.Item2.All(char.IsDigit))
                {
                    return _valid.IsString();
                }
            }
            return _valid.IsOk();
        }

        public string CheckValues(List<Tuple<int, string, string, string>> values)
        {
            if (CheckString(values) != "ok") return CheckString(values);
            if (CheckInt(values) != "ok") return CheckInt(values);
            if (CheckBool(values) != "ok") return CheckBool(values);
            return _valid.IsOk();
        }
    }
}
