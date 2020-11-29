using Microsoft.AspNetCore.Mvc;
using Service.ShowInformation;
using VirtualTable.Mapper;

namespace VirtualTable.Controllers
{
    public class ShowInfoController : Controller
    {
        IShowInfo _service;
        IMap _map;
        public ShowInfoController(IShowInfo service ,IMap map)
        {
            _service = service;
            _map = map;
        }
        /// <summary>
        /// show data of table 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ShowData(int id)
        {
            ViewData["column"] = _service.AllType(id);
            var values =_map.ValueList(_service.ValueOfTable(id));
            return View(values);
        }

       
    }
}
