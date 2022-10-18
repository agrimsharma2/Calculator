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
            double a = Convert.ToDouble(firstNumber);
            double b = Convert.ToDouble(secondNumber);
            double c = 0;
            switch (Cal)
            {
                case "Add":
                    c = _adding.Add(a, b);
                    break;
                case "Sub":
                    c = (double)a - b;
                    break;
                case "Mul":
                    c = (double)a * b;
                    break;
                case "Div":
                    c = (double)a / b;
                    break;
            }
            ViewBag.Result = c;
            return View();
        }
    }
}