using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Project1.Models;
using Newtonsoft.Json;
namespace Project1.Controllers {
    public class TripController : Controller {

        private TripContext context { get; set; }

        public TripController(TripContext ctx) {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add() {  
            return View();
        }

        [HttpPost]
        public IActionResult Add(Trip trip) {
            if (ModelState.IsValid) {
                TempData["trip"] = JsonConvert.SerializeObject(trip);
                if (trip.AccommodationName == null) {

                    return RedirectToAction(nameof(EnterThingsToDo));
                }
                return RedirectToAction(nameof(EnterAccommodationDetails));
            }
            TempData["message"] = "Input failed. Please begin again.";
            return View();
        }

        [HttpGet]
        public IActionResult EnterAccommodationDetails() {
            if (TempData["trip"] != null) {

                Trip oldTrip = JsonConvert.DeserializeObject<Trip>(TempData["trip"].ToString());
                ViewBag.AccommodationName = oldTrip.AccommodationName;
                TempData["trip"] = JsonConvert.SerializeObject(oldTrip);
            }
            return View();

        }

        [HttpPost]
        public IActionResult EnterAccommodationDetails(Trip trip) {
            if (TempData["trip"] != null) {

                Trip oldTrip = JsonConvert.DeserializeObject<Trip>(TempData["trip"].ToString());
                oldTrip.AccommodationPhone = trip.AccommodationPhone;
                oldTrip.AccommodationEmail = trip.AccommodationEmail;
                TempData["trip"] = JsonConvert.SerializeObject(oldTrip);
                return RedirectToAction(nameof(EnterThingsToDo));
            }
            ViewBag.Message = "Input failed. Please begin again.";
            return View("Index");
        }

        [HttpGet]
        public IActionResult EnterThingsToDo() {
            if (TempData["trip"] != null) {

                Trip oldTrip = JsonConvert.DeserializeObject<Trip>(TempData["trip"].ToString());
                ViewBag.Destination = oldTrip.Destination;
                TempData["trip"] = JsonConvert.SerializeObject(oldTrip);
            }
            return View();
        }
        [HttpPost]
        public IActionResult EnterThingsToDo(Trip trip) {
            if (TempData["trip"] != null) {

                Trip oldTrip = JsonConvert.DeserializeObject<Trip>(TempData["trip"].ToString());
                oldTrip.ThingToDo1 = trip.ThingToDo1;
                oldTrip.ThingToDo2 = trip.ThingToDo2;
                oldTrip.ThingToDo3 = trip.ThingToDo3;
                TempData.Clear();
                context.Add(oldTrip);
                context.SaveChanges();
                TempData["message"] = oldTrip.Destination;
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction(nameof(EnterThingsToDo));
        }

        [HttpGet]
        public IActionResult Cancel() {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
    }    
}

