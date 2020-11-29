using Models.Entity;
using Repository.Context;
using System.Collections.Generic;

namespace Service.ShowInformation
{
    public class ShowInfo : IShowInfo
    {
        IUnitOfWork _db;
        public ShowInfo(IUnitOfWork db)
        {
            _db = db;
        }
        public List<string> AllType(int id)
        {
            return _db.Types.AllType(x => x.TableId == id, x => x.Field_Name);
        }

        public List<Value> ValueOfTable(int id)
        {
           return _db.Value.TableColumn(x => x.TableId == id);
        }
    }
}
