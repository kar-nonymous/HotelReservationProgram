using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservation
    {
        /// <summary>
        /// Dictionary to contain the hotel name and rate.
        /// </summary>
        public static Dictionary<string, HotelDetails> miamiHotels = new Dictionary<string, HotelDetails>();
        /// <summary>
        /// UC 1:
        /// Adds hotel and price
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="regularRate"></param>
        public void AddHotel(string hotel, int regularWeekdayRate, int regularWeekendRate,int rating)
        {
            HotelDetails hotelDetails = new HotelDetails(hotel, regularWeekdayRate, regularWeekendRate, rating);
            miamiHotels.Add(hotel, hotelDetails);
        }
        readonly int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        /// <summary>
        /// Method to count the leap years
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int CountLeapYears(Date date)
        {
            int year = date.year;
            if (date.month <= 2)
                year--;
            return year / 4 - year / 100 + year / 400;
        }
        /// <summary>
        /// Method to get the number of days between 2 dates
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public int NoOfDays(Date startDate, Date endDate)
        {
            int n1 = startDate.year * 365 + startDate.day;
            for (int i = 0; i < startDate.month - 1; i++)
            {
                n1 += months[i];
            }
            n1 += CountLeapYears(startDate);
            int n2 = endDate.year * 365 + endDate.day;
            for (int i = 0; i < endDate.month - 1; i++)
            {
                n2 += months[i];
            }
            n2 += CountLeapYears(endDate);
            return n2 - n1;
        }
        /// <summary>
        /// Class to get the date
        /// </summary>
        public class Date
        {
            public int day;
            public int month;
            public int year;
            public Date(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }
        /// <summary>
        /// UC 2:
        /// Returns the cheapest hotel
        /// </summary>
        public void CheapestHotel()
        {
            Date startDate = new Date(14, 10, 2020);
            Date endDate = new Date(20, 10, 2020);
            Dictionary<string, int> rateList = new Dictionary<string, int>();
            foreach (var value in miamiHotels)
            {
                int rate = value.Value.regularWeekdayRate * NoOfDays(startDate, endDate);
                rateList.Add(value.Value.hotel, rate);
            }
            var keyValuePair = rateList.OrderBy(keyValuePair => keyValuePair.Value).First();
            Console.WriteLine("Cheapest Hotel: {0} and Rate: {1}", keyValuePair.Key, keyValuePair.Value);
        }
        /// <summary>
        /// UC 4:
        /// Returns the cheapest hotel with weekend price included
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public void CheapestHotelWithWeekendRate(DateTime startDate, DateTime endDate)
        {
            int finalRate = 0;
            Dictionary<string, int> weekendRateList = new Dictionary<string, int>();
            foreach(var value in miamiHotels)
            {
                while (startDate != endDate.AddDays(1))
                {
                    if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                        finalRate += value.Value.regularWeekendRate;
                    else
                        finalRate += value.Value.regularWeekdayRate;
                    weekendRateList.Add(value.Value.hotel, finalRate);
                    startDate = startDate.AddDays(1);
                }
            }
            var keyValuePair = weekendRateList.OrderBy(keyValuePair => keyValuePair.Value).First();
            Console.WriteLine("Cheapest hotel: {0} and Rate: {1}", keyValuePair.Key, keyValuePair.Value);
        }
    }
}
