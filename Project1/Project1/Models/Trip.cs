using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models {
    public class Trip {

        public int TripId { get; set; }
        [Required(ErrorMessage = "Please enter a destination.")]
        public string Destination { get; set; }
        [Required(ErrorMessage = "Please enter a start date.")]
        //[DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Please enter an end date.")]
        //[DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string AccommodationName { get; set; }

        public string AccommodationPhone { get; set; }
        public string AccommodationEmail{ get; set; }
        public string ThingToDo1 { get; set; }
        public string ThingToDo2 { get; set; }
        public string ThingToDo3 { get; set; }


        public string AccomodationsStringBuilder() {
            string phoneAndEmailRow = null;
            if(AccommodationPhone != null && AccommodationEmail != null) {
                phoneAndEmailRow =  AccommodationPhone + " | " + AccommodationEmail;
            }
            return AccommodationName + "\n" + phoneAndEmailRow;
        }

        public string ThingsToDoStringBuilder() {
            return ThingToDo1 + "\n" + ThingToDo2 + "\n" + ThingToDo3;  


        }



    }
}
