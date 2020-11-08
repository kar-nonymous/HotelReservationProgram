using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("**********WELCOME TO HOTEL RESERVATION PROGRAM**********");
            Console.WriteLine("********************************************************");
            /// Object of the HotelReservation class
            HotelReservation hotelReservation = new HotelReservation();
            /// Adding hotel's name and rate 
            hotelReservation.AddHotel("Lakewood", 110, 90);
            hotelReservation.AddHotel("Bridgewood", 150, 50);
            hotelReservation.AddHotel("Ridgewood", 220, 150);
            /// Cheapest hotel
            hotelReservation.CheapestHotel();
        }
    }
}
