using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelDetails
    {
        public string hotel;
        public int regularWeekdayRate;
        public int regularWeekendRate;
        public int rating;
        public HotelDetails(string hotel, int regularWeekdayRate, int regularWeekendRate, int rating)
        {
            this.hotel = hotel;
            this.regularWeekdayRate = regularWeekdayRate;
            this.regularWeekendRate = regularWeekendRate;
            this.rating = rating;
        }
    }
}
