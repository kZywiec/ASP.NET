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
        public IActionResult DateOfBirth(DateOfBirth_Form dateOfBirth_Form)
        {
            ViewBag.Message = "please enter your data";
            ViewBag.UserDateOfBirth = "";
            if (dateOfBirth_Form.Name != "")
                ViewBag.Message = dateOfBirth_Form.Name;

            if (dateOfBirth_Form.Age == null)
                return View();

            else if (dateOfBirth_Form.Age <= 0)
                ViewBag.UserDateOfBirth = "Sorry but you need to born to use ower website. Nothing personal just company's policy.";

            else if (dateOfBirth_Form.Age < 6)
                ViewBag.UserDateOfBirth = "Ok now shout out: MAMA! ...wait... Hello Madam, your child should be at least 6 years old to use this website.";

            else if (dateOfBirth_Form.Age < 150)
                ViewBag.UserDateOfBirth = $"So if you are {dateOfBirth_Form.Age}y.o. and we have {DateTime.Now.Year}. You born in {DateTime.Now.Year - dateOfBirth_Form.Age}.";

            else
                ViewBag.UserDateOfBirth = $"So if you are {dateOfBirth_Form.Age}y.o. and we have {DateTime.Now.Year}. You're death of a Vimpire. Logg out we have a garlic!";
            
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