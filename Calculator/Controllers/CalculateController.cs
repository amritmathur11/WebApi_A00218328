using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCalc;

namespace Calculator.Controllers
{
    public class CalculateController : System.Web.Mvc.Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(decimal num1 = 0, decimal num2 = 0, string operation = "")
        {
            if (operation == null || operation == "")
            {
                return View();
            }
            SimpleCalc.SimpleCalc simpleCalc = new SimpleCalc.SimpleCalc();
            ViewData["result"] = simpleCalc.OperatorSwitch(num1,num2,operation);
            return View();
        }
    }
}