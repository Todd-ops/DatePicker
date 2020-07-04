using System;
using System.Collections.Generic;

namespace DatePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateList = new List<string>();
            dateList.Add("Movie Night");
            dateList.Add("Cook at home");
            dateList.Add("Bowling");
            dateList.Add("Cancun Margaritas");
            dateList.Add("Night Walk");
            dateList.Add("R.C.C. Dinner");
            dateList.Add("Backyard Camp Fire");
            dateList.Add("Card Game Night");
            dateList.Add("Alexa Games");
            dateList.Add("Let Becky Decide");

            var randomPicker = new Random();
            var randoString = randomPicker.Next(dateList.Count);
            Console.WriteLine($"{dateList[randoString]}");

        }

        //public void RandomDatePicker()
        
            //var randomPicker = new Random();
            //var randoString = randomPicker.Next(dateList.Count);
        
        
    }
}
