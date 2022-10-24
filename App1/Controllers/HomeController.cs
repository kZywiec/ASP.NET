using App1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DateOfBirth()
        {
            return View();
        }
        public IActionResult Calculator_Form()
        {
            return View();
        }
        public IActionResult Calculate(Calc_Model calc_Model)
        {
            ViewBag.CalcResoult = "";

            if (calc_Model.Operator == '+')
                ViewBag.CalcResoult += calc_Model.Addition();

            else if (calc_Model.Operator == '-')
                ViewBag.CalcResoult += calc_Model.Subtraction();

            else if (calc_Model.Operator == '*')
                ViewBag.CalcResoult += calc_Model.Multiplication();

            else if (calc_Model.Operator == '/')
                ViewBag.CalcResoult += calc_Model.Division();
            return View("Calculator_Form");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}