using Infrastructure.DTO;
using Models.Entity;
using Repository.Context;
using System.Collections.Generic;
using Validation.AddValueToDB;

namespace Service.Addvalue
{
    public class AddvalueToDB : IAddValue
    {
        IUnitOfWork _db;
        ICheckValue _check;
        public AddvalueToDB(IUnitOfWork db , ICheckValue check)
        {
            _db = db;
            _check = check;
        }

        public string AddToValueTable(List<ValueDTO> values)
        {
            if (_check.CheckValues(values) != "ok") return _check.CheckValues(values);
            foreach (var item in values)
            {
                _db.Value.Insert(new Value { TableId = item.TableId, FieldValue = item.FieldValue, Column = item.Column });
            }
            _db.Save();
            return "ok";
        }

        public List<Tables> AllTable()
        {
           return _db.Tables.GetAll();
        }

        public List<Types> TableData(int id)
        {

            return _db.Types.TableColumn(x => x.TableId == id);
        }
    }
}
