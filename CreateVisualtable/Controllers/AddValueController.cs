using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateVisualtable.ViewModel;
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

        [HttpGet]
        public IActionResult ChooseTable()
        {
            List<(int id, string TableName)> list = new List<(int id, string TableName)>();
            var list1 = _service.AllTable();
            foreach (var item in list1)
            {
                list.Add((item.Id,item.TableName));
            }
            ViewData["Table"] = list;

            return View();
        }

        [HttpGet]
        public IActionResult SeedData(int id)
        {
            var TableData = _service.TableData(id);
            List<TypeView> model = new List<TypeView>();
            ////fill viewmodel with corrent  information
            foreach (var item in TableData)
            {
                model.Add(new TypeView
                {
                    Field_Name = item.Field_Name,
                    Field_Type = item.Field_Type,
                    TableId = item.TableId,
                    Value = null

                });

            }

            return View(model);
        }
        [HttpPost]
        public IActionResult SeedData(List<ValueView> values, List<TypeView> model)
        {
            ////fill ViewModel with information
            for (int i = 0; i < values.Count; i++)
            {
                model.Add(new TypeView
                {
                    Field_Type = values[i].Type,
                    Field_Name = values[i].Column,
                    TableId = values[i].TableId
                    ,
                    Value = values[i].FieldValue
                });
            }
            if (ModelState.IsValid)
            {
                string error = _service.AddToValueTable(ValueList(values));
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
        /// <summary>
        /// return a list : TableId -  FieldValue -  Column  - Type
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        List<(int id, string fieldvalue, string column,string type)> ValueList(List<ValueView> values)
        {
            List<(int id, string fieldvalue, string column, string type)> list = new List<(int id, string fieldvalue, string column, string type)>();
            foreach (var item in values)
            {
                list.Add((item.TableId, item.FieldValue, item.Column ,item.Type.ToString()));
            }
            return list;
        }       
}    
}
