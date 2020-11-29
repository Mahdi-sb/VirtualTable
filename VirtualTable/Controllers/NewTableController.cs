using Microsoft.AspNetCore.Mvc;
using Service.AddNewTable;
using VirtualTable.Mapper;
using VirtualTable.ViewModel;

namespace VirtualTable.Controllers
{
    public class NewTableController : Controller
    {
        IAddTable _service;
        IMap _map;
        public NewTableController(IAddTable service , IMap map)
        {
            _map = map;
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
                var types = _map.TypeList(model);
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