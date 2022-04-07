using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using TempManager.Models;

namespace Ch11Ex1TempManager.Controllers
{
    public class HomeController : Controller
    {
        private TempManagerContext data { get; set; }
        public HomeController(TempManagerContext ctx) => data = ctx;

        public ViewResult Index()
        {
            var temps = data.Temps.OrderBy(t => t.Date).ToList();
            return View(temps);
        }

        [HttpGet]
        public ViewResult Add() => View(new Temp());

        [HttpPost]
        public IActionResult Add(Temp temp)
        {
            Temp dateCheck = data.Temps.FirstOrDefault(d => d.Date == temp.Date);
            if (dateCheck != null) {
                string shortDate = temp.Date.ToString().Substring(0, 9);
                ModelState.AddModelError("Date", $"{shortDate} is already listed in the database.");
            }
                if (ModelState.IsValid) {

                    data.Temps.Add(temp);
                    data.SaveChanges();

                    return RedirectToAction("Index");
                }
                else {
                    ModelState.AddModelError("", "Please correct all errors.");
                    return View(temp);
                }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var temp = data.Temps.Find(id);
            return View(temp);
        }

        [HttpPost]
        public RedirectToActionResult Delete(Temp temp)
        {
            data.Remove(temp);
            data.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
