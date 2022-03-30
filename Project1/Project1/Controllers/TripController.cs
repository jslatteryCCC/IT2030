using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Project1.Models;
using System.Text.Json;
namespace Project1.Controllers {
    public class TripController : Controller {

        private TripContext context { get; set; }

        public TripController(TripContext ctx) {
            context = ctx;
        }
        [HttpGet]
        public IActionResult LinkToCreateNewTrip() {
            return View("CreateNewTrip", new Trip());
        }

        [HttpPost]
        public IActionResult CreateNewTrip(Trip trip) {
            context.Trips.Add(trip);

            if (trip.AccommodationName == null) {
                return View("EnterThingsToDo", trip);
            }
            return View("EnterAccommodationDetails", trip);
        }
        [HttpPost]
        public IActionResult EnterAccommodationDetails(Trip trip) {
            return View("EnterThingsToDo", trip);
        }
        [HttpPost] 
        public IActionResult AddToDb(Trip trip) {
            context.SaveChanges();

            return View("Home", "Index");
        }
    }
}

