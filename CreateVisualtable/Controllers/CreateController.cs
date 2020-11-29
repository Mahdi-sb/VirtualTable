using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateVisualtable.ViewModel;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Service.CreateTable;

namespace CreateVisualtable.Controllers
{
    public class CreateController : Controller
    {
        IAddTable _service;
        public CreateController(IAddTable service)
        {
            _service = service;
        }



        [HttpGet]
        public IActionResult AddNewTable()
        {
            TableView Table = new TableView();
            return View(Table);
            
        }

        [HttpPost]
        public ActionResult AddNewTable(TableView model)
        {
            if (ModelState.IsValid)
            {
                List<TypesDTO> types = new List<TypesDTO>();
                foreach (var item in model.TypeList)
                {
                    types.Add(new TypesDTO(item.ColumnName, item.Type.ToString()));
                }

                string error=_service.AddInformationTodatabase(model.TableName, types);

                if (error != "ok")
                {
                    ViewData["ErrorMessage"] = error;
                    return View("AddNewTable", model);
                }
                return RedirectToAction("Index", "Home");
            }
            return View("AddNewTable", model);
        }


    }
}