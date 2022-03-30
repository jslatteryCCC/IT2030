/*using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;



namespace Project1.Models {
    public class TripSession {

        private const string DestinationKey = "Destination";
        private const string StartDateKey = "StartDate";
        private const string EndDateKey = "EndDate";
        private const string AccommodationNameKey = "AccommodationName";
        private const string AccommodationPhoneKey = "AccommodationPhone";
        private const string AccommodationEmailKey = "AccommodationEmail";
        private const string ThingToDo1Key = "ThingToDo1";
        private const string ThingToDo2Key = "ThingToDo2";
        private const string ThingToDo3Key = "ThingToDo3";
        private ISession session { get; set; }
            
        public TripSession(ISession session) {
            this.session = session;
        }

        public void SetDest(string destinationValue) {
            session.SetString(DestinationKey, destinationValue);
        }
        public void SetStart(DateTime start) {
            session.SetString(StartDateKey, start.ToShortDateString());
        }
        public void SetEnd(DateTime end) {
            session.SetString(EndDateKey, end.ToShortDateString());
        }
        public void SetAccName(string accName) {
            session.SetString(AccommodationNameKey, accName);
        }
        public void Set
        public void GetDest(string destKey) => session.GetString(DestinationKey);
    }
}*/
