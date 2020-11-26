using System;
using System.Collections.Generic;
using System.Text;

namespace Validation.AddValueToDB
{
   public interface ICheckValue
    {
        /// <summary>
        /// check field value to not have digit on it
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        string CheckString(List<Tuple<int, string, string, string>> values);
        /// <summary>
        /// check field value to Bool type
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        string CheckBool(List<Tuple<int, string, string, string>> values);
        /// <summary>
        /// check field value to int type
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        string CheckInt(List<Tuple<int, string, string, string>> values);
        /// <summary>
        /// check values is Correct
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        string CheckValues(List<Tuple<int, string, string, string>> values);
    }
}
