using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.ShowInformation;

namespace CreateVisualtable.Controllers
{
    public class ShowInfoController : Controller
    {
        IShowInfo _service;
        public ShowInfoController(IShowInfo service)
        {
            _service = service;
        }
        /// <summary>
        /// show data of table 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ShowData(int id)
        {
            ViewData["column"] = _service.AllType(id);
            var value = _service.ValueOfTable(id);

            List<Tuple<int, string, string>> values = new List<Tuple<int, string, string>>();
            foreach (var item in value)
            {
                values.Add(new Tuple<int, string, string>(item.TableId, item.FieldValue, item.Column));
            }

            return View(values);//_show.ValueOfTable(id));
        }

       
    }
}
