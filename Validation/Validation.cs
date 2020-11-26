using System;
using System.Collections.Generic;
using System.Text;

namespace Validation
{
    public class Validation : IValidation
    {
        public string AddColumn()
        {
            return "ستون جدول اضافه کنید";
        }

        public string RepetitiveColumnName()
        {
            return "نام ستون تکراری است";
        }

        public string RepetitiveTableName()
        {
            return "نام جدول در دیتابیس موجود میباشد";
        }

        public string IsOk()
        {
            return "ok";
        }

        public string IsBool()
        {
            return "متغیر از نوع BOOL فقط شامل true یا false میباشد .";
        }

        public string IsString()
        {
            return "متغیر از نوع STRING نمیتواند تماما شامل عدد باشد.";
        }

        public string IsInt()
        {
            return "متغیر از نوع INT نمیتواند شامل حروف باشد.";
        }
    }
}
