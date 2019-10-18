using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodGenerator.Controllers
{
    public class RandomController : Controller
    {
                
        
        // GET: /<controller>/
        public IActionResult RandomBreakfast()
        {

            return View();
        }

        
       
    }
}
