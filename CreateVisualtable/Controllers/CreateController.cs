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

        List<Tuple<string, string>> TypeList(TableView model)
        {
            List<(string name, string sa)> name = new List<(string name, string sa)>();
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            foreach (var item in model.TypeList)
            {
                list.Add(new Tuple<string, string>(item.Type.ToString(), item.ColumnName));
            }
            return list;
        }

    }
}
