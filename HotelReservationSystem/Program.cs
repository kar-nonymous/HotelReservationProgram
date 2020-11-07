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
            hotelReservation.AddHotel("Lakewood", 110);
            hotelReservation.AddHotel("Bridgewood", 160);
            hotelReservation.AddHotel("Ridgewood", 220);
        }
    }
}
