using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelDetails
    {
        public string hotel;
        public int regularRate;
        public HotelDetails(string hotel, int regularRate)
        {
            this.hotel = hotel;
            this.regularRate = regularRate;
        }
    }
}
