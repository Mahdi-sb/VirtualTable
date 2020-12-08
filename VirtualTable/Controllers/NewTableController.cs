using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Service.AddNewTable;
using VirtualTable.Mapper;
using VirtualTable.ViewModel;

namespace VirtualTable.Controllers
{
    public class NewTableController : Controller
    {
        private readonly IAddTable _service;
        public NewTableController(IAddTable service)
        {
            _service = service;
        }



        [HttpGet]
        public IActionResult AddNewTable()
        {
            var table = new TableView();
            return View(table);
            
        }

        [HttpPost]
        public ActionResult AddNewTable(TableView model)
        {
            if (!ModelState.IsValid) return View("AddNewTable", model);
            var types = Map.TypeList(model);
            var error=_service.AddInformationToDatabase(model.TableName, types);
            if (error == Massage.IsOk) return RedirectToAction("Index", "Home");
            ViewData["ErrorMessage"] = error;
            return View("AddNewTable", model);
        }


    }
}