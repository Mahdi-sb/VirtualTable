using System.Collections.Generic;
using Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;
using Service.Addvalue;
using VirtualTable.Mapper;

namespace VirtualTable.Controllers
{
    public class AddValueController : Controller
    {
        IAddValue _service;
        IMap _map;
        public AddValueController(IAddValue service ,IMap map)
        {
            _service = service;
            _map = map;
        }

        /// <summary>
        /// create page to choose table
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ChooseTable()
        {
            var list = _map.TableList(_service.AllTable());

            return View(list) ;
        }

        /// <summary>
        /// seed data in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SeedData(int id)
        {
            var model =_map.TypeList( _service.TableData(id));
            return View(model);
        }
        [HttpPost]
        public IActionResult SeedData(List<ValueDTO> values, List<TypesDTO> model)
        {
            model = _map.TypeList(values);            
            if (ModelState.IsValid)
            {
                
                string error = _service.AddToValueTable(values);
                if (error != "ok")
                {
                    ViewData["ErrorMessage"] = error;
                    return View(model);
                }
                return RedirectToAction("Index", "Home");
            }
            ViewData["ErrorMessage"] = "فیلد هارا پر کنید";
            return View(model);
        }
        
}    
}
