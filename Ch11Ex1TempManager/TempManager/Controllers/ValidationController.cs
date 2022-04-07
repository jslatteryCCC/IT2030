using Microsoft.AspNetCore.Mvc;
using TempManager.Models;
using System;
using System.Linq;

namespace TempManager.Controllers {
    public class ValidationController : Controller {
        private TempManagerContext context { get; set; }
        public ValidationController(TempManagerContext ctx) {
            context = ctx;
        }

        public JsonResult CheckDate(string date) {
            DateTime dateTime = DateTime.Parse(date);
            Temp temp = context.Temps.FirstOrDefault(t => t.Date == dateTime);

            if (temp == null) {
                return Json(true);
            }
            else return Json($"{date} is already listed in the database");
        }

    }
}
