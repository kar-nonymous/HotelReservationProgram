using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservation
    {
        /// <summary>
        /// Dictionary to contain the hotel name and rate
        /// </summary>
        public static Dictionary<string, HotelDetails> miamiHotels = new Dictionary<string, HotelDetails>();
        /// <summary>
        /// UC 1:
        /// Adds hotel and price
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="regularRate"></param>
        public void AddHotel(string hotel, int regularRate)
        { 
            HotelDetails hotelDetails = new HotelDetails(hotel, regularRate);
            miamiHotels.Add(hotel, hotelDetails);
        }
    }
}
