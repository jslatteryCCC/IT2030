using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers {
    public class HomeController : Controller {

        private TripContext context { get; set; }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, TripContext ctx) {  
            _logger = logger;
            context = ctx;
        }
        [HttpGet]
        public IActionResult Index() {
            if(TempData["message"] != null) {
                ViewBag.Message = TempData["message"].ToString();
            }
            var trips = context.Trips.OrderBy(t => t.Destination).ToList();
            return View(trips);
        }

    }
}
