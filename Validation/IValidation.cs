using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
    public interface IValidation
    {
        /// <summary>
        /// check table name not exixt in database
        /// </summary>
        /// <returns></returns>
        string RepetitiveTableName();
        /// <summary>
        /// check column name not repetitive
        /// </summary>
        /// <returns></returns>
        string RepetitiveColumnName();
        /// <summary>
        /// if No column Added return error
        /// </summary>
        /// <returns></returns>
        string AddColumn();
        /// <summary>
        /// if no error return ok
        /// </summary>
        /// <returns></returns>
        string IsOk();

        /// <summary>
        /// return error if type and value not  match
        /// </summary>
        /// <returns></returns>
        string IsBool();
        /// <summary>
        /// return error if type and value not  match 
        /// </summary>
        /// <returns></returns>
        string IsString();
        /// <summary>
        /// return error if type and value not  match
        /// </summary>
        /// <returns></returns>
        string IsInt();

    }
}
