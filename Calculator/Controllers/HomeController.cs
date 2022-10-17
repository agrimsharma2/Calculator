using Calculator.Models;
using Calculator.Process;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly Adding _adding = new Adding();

        public HomeController()
        {
            ///_adding = adding;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult Index(string firstNumber, string secondNumber, string Cal)
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            float c = 0;
            switch (Cal)
            {
                case "Add":
                    c = _adding.Add(a, b);
                    break;
                case "Sub":
                    c = (float)a - b;
                    break;
                case "Mul":
                    c = (float)a * b;
                    break;
                case "Div":
                    c = (float)a / b;
                    break;
            }
            ViewBag.Result = c;
            return View();
        }
    }
}