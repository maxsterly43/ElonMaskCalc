using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM.Calc.Web.Models;

namespace EM.Calc.Web.Controllers
{
    public class CalcController : Controller
    {
        Core.Calc calc;

        public CalcController()
        {
            calc = new Core.Calc();
        }

        public ActionResult Execute(string oper, double[] values)
        {
            return View(Calc(oper, values));
        }

        [HttpGet]
        public ActionResult Input()
        {
            return View(new InputModel { Operations = calc.Operations });
        }

        [HttpPost]
        public PartialViewResult Input(InputModel model)
        {
            if (!ModelState.IsValid)
                return null;
            if (!calc.GetOperationsName.Contains(model.Name))
            {
                ModelState.AddModelError("Name", "Такой операции нет");
                return null;
            }
            var result = Calc(model.Name, model.values);
            return PartialView("Execute", result);
        }

        private OperationResult Calc(string oper, double[] values)
        {
            var result = calc.Execute(oper, values);
            return new OperationResult() { Name = oper, Result = result };
        }
    }
}