using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new Calc());
        }

        [HttpPost]
        public ActionResult Index(Calc calc, string calculate)
        {
            Queue<History> calchistry = new Queue<History>(); 

            switch (calculate)
            {
                case "add":
                    calc.total = calc.number1 + calc.number2;
                    calchistry.Enqueue(new History(calc.number1, calc.number2, calc.total));
                    break;
                case "minus":
                    calc.total = calc.number1 - calc.number2;
                    calchistry.Enqueue(new History(calc.number1, calc.number2, calc.total));
                    break;
                case "multiply":
                    calc.total = calc.number1 * calc.number2;
                    calchistry.Enqueue(new History(calc.number1, calc.number2, calc.total));
                    break;
                case "divide":
                    calc.total = calc.number1 / calc.number2;
                    calchistry.Enqueue(new History(calc.number1, calc.number2, calc.total));
                    break;
                case "m+":
                    calc.memoryStore += calc.total;
                    break;
                case "m-":
                    calc.memoryStore -= calc.total;
                    break;
                case "recall":
                    calc.memoryStore = calc.total;
                    break;
                default:
                    break;
            }

            return View(calc);

        }

    }
}