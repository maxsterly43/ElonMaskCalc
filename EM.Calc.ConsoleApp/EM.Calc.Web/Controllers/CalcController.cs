using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class CalcController : Controller
    {

        Core.Calc calc = new Core.Calc();
        public ActionResult Execute(string oper, string values)
        {
            double[] operands = values.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => Convert.ToDouble(i)).ToArray();
            ViewBag.Result = calc.Execute(oper, operands);
            return View();
        }
    }
}
