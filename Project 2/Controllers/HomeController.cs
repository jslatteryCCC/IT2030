using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2.Controllers {
    public class HomeController : Controller {

        [HttpGet]
        public IActionResult Index() {
            ViewBag.DiscountAmount = 0;
            ViewBag.Total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceModel price) {
            if (ModelState.IsValid) {
                ViewBag.DiscountAmount = price.DiscountAmountCalculator((double)price.Subtotal, (double)price.DiscountPercent);
                ViewBag.Total = price.TotalCalculator((double)price.Subtotal, (double)price.DiscountAmount);
            }
            else {
                ViewBag.DiscountAmount = 0;
                ViewBag.Total = 0;
            }
            return View("Index", price);
        }

    }

}
