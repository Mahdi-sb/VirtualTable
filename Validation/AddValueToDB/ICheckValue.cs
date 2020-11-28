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
        string CheckString(List<(int id, string fieldvalue, string column, string type)> values);
        /// <summary>
        /// check field value to Bool type
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        string CheckBool(List<(int id, string fieldvalue, string column, string type)> values);
        /// <summary>
        /// check field value to int type
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        string CheckInt(List<(int id, string fieldvalue, string column, string type)> values);
        /// <summary>
        /// <returns></returns>
        /// check values is Correct
        /// </summary>
        /// <param name="values"></param>
        string CheckValues(List<(int id, string fieldvalue, string column, string type)> values);
    }
}
