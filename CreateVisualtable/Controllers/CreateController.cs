using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateVisualtable.ViewModel;
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

                string error=_service.AddInformationTodatabase(model.TableName, TypeList(model));

                if (error != "ok")
                {
                    ViewData["ErrorMessage"] = error;
                    return View("AddNewTable", model);
                }
                return RedirectToAction("Index", "Home");
            }
            return View("AddNewTable", model);
        }

        List<(string type, string columnName)> TypeList(TableView model)
        {
            List<(string type, string columnName)> list = new List<(string type, string columnName)>();
            foreach (var item in model.TypeList)
            {
                list.Add((item.Type.ToString(), item.ColumnName));
            }
            return list;
        }

    }
}
