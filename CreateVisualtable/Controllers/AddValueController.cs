using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateVisualtable.ViewModel;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Service.Addvalue;

namespace CreateVisualtable.Controllers
{
    public class AddValueController : Controller
    {
        IAddValue _service;
        public AddValueController(IAddValue service)
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
            List<TableDTO> list = new List<TableDTO>();
            var list1 = _service.AllTable();
            foreach (var item in list1)
            {
                list.Add( new TableDTO(item.Id,item.TableName));
            }
            ViewData["Table"] = list;

            return View();
        }

        /// <summary>
        /// seed data in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SeedData(int id)
        {
            var TableData = _service.TableData(id);
            List<TypesDTO> model = new List<TypesDTO>();
            ////fill viewmodel with corrent  information
            foreach (var item in TableData)
            {
                model.Add(new TypesDTO(item.TableId, item.Field_Name, item.Field_Type, null));
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult SeedData(List<ValueDTO> values, List<TypesDTO> model)
        {
            ////fill ViewModel with information
            for (int i = 0; i < values.Count; i++)
            {
                model.Add(new TypesDTO(values[i].TableId, values[i].Column, values[i].Type, values[i].FieldValue));
            }
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
