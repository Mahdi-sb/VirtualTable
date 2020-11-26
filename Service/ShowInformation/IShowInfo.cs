using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ShowInformation
{
    public interface IShowInfo
    {

        public List<Value> ValueOfTable(int id);
        public List<string> AllType(int id);



    }
}
