using System.Collections.Generic;
using Infrastructure;
using Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;
using Service.Addvalue;
using VirtualTable.Mapper;

namespace VirtualTable.Controllers
{
    public class AddValueController : Controller
    {
        IAddValue _service;
        public AddValueController(IAddValue service )
        {
            _service = service;
        }

        /// <summary>
        /// create page to choose table
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ChooseTable()
        {
            var list = Map.TableList(_service.AllTable());

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
            var model =Map.TypeList( _service.TableData(id));
            return View(model);
        }
        [HttpPost]
        public IActionResult SeedData(List<ValueDto> values, List<TypesDto> model)
        {
            
            model = Map.TypeList(values);            
            if (ModelState.IsValid)
            {
                
                var error = _service.AddToValueTable(values);
                if (error == Massage.IsOk) return RedirectToAction("Index", "Home");
                ViewData["ErrorMessage"] = error;
                return View(model);
            }
            ViewData["ErrorMessage"] = Massage.FillFields;
            return View(model);
        }
        
}    
}
