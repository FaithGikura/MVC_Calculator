using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Meal meal)
        {
            if (ModelState.IsValid && meal.Cost > 0)
            {
                ViewBag.Tip15 = meal.CalculateTip(15);
                ViewBag.Tip18 = meal.CalculateTip(18);
                ViewBag.Tip20 = meal.CalculateTip(20);
            }
            else
            {
                ViewBag.ErrorMessage = "Please enter a valid meal cost greater than 0.";
                ViewBag.Tip15 = ViewBag.Tip18 = ViewBag.Tip20 = 0.00M;
            }

            return View(meal);
        }
    }
}