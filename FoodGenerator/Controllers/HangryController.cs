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
        private HangryModel _context;
        public HangryController(HangryModel context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.BreakfastMeals.ToList());
        }


    }
}
