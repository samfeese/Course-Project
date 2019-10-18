using FoodGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodGenerator.Controllers
{
    public class HangryController : Controller
    {
        private readonly HangryModel _context;
        public HangryController(HangryModel context)
        {
            _context = context;
        }
        public IActionResult BreakfastInput()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddItem(string Name, string Description)
        {
            var breakfastItem = new BreakfastMeal { Name = Name, Description = Description };
            _context.Add(breakfastItem);
            _context.SaveChanges();
            ViewBag.Name = Name;
            ViewBag.Desc = Description;
            return View("BreakfastInput");
        }
       


    }
}
