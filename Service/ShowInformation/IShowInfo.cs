using Models.Entity;
using System.Collections.Generic;

namespace Service.ShowInformation
{
    public interface IShowInfo
    {

        public List<Value> ValueOfTable(int id);
        public List<string> AllType(int id);



    }
}
