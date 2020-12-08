using Microsoft.AspNetCore.Mvc;
using Service.ShowInformation;
using VirtualTable.Mapper;

namespace VirtualTable.Controllers
{
    public class ShowInfoController : Controller
    {
        private readonly IShowInfo _service;
        public ShowInfoController(IShowInfo service )
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
            var values =Map.ValueList(_service.ValueOfTable(id));
            return View(values);
        }

       
    }
}
