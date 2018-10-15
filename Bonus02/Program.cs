using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus02
{
    class Program
    {

        static string Month(string monthString)
        {

            string month;

            switch (monthString)
            {

                case "1":
                case "January":
                case "january":
                    return month = "1";

                case "2":
                case "February":
                case "february":
                    return month = "2";

                case "3":
                case "March":
                case "march":
                    return month = "3";

                case "4":
                case "April":
                case "april":
                    return month = "4";

                case "5":
                case "May":
                case "may":
                    return month = "5";

                case "6":
                case "June":
                case "june":
                    return month = "6";

                case "7":
                case "July":
                case "july":
                    return month = "7";

                case "8":
                case "August":
                case "august":
                    return month = "8";

                case "9":
                case "September":
                case "september":
                    return month = "9";

                case "10":
                case "October":
                case "october":
                    return month = "10";

                case "11":
                case "November":
                case "november":
                    return month = "11";

                case "12":
                case "December":
                case "december":
                    return month = "12";

                default:
                    Console.WriteLine("\nSorry, that doesn't seem to be a valid month.");
                    Console.WriteLine("Try it again by entering the numerical value or the name of the month (i.e January)\n");
                    return month = "0";

            }
        }

        static void Main(string[] args)
        {
            bool realBirthday = false;
            DateTime birthday;
            int yearNumber;
            int monthNum;
            int dayNumber;
            string birthdayString;

            do
            {
                Console.WriteLine("Please enter your birthday");

                yearNumber = 0;
                string year;
                bool realYear = false;
                do
                {
                    Console.Write("What year were you born? ");
                    year = Console.ReadLine();
                    realYear = int.TryParse(year, out yearNumber);

                    if (realYear == true)
                    {
                        if (yearNumber > DateTime.Now.Year)
                        {
                            Console.WriteLine("Welcome from the future! Maybe enter the birth of a non-time traveler.");
                            realYear = false;
                        }
                        if (yearNumber < 1900)
                        {
                            Console.WriteLine("Wow, that is mighty old, maybe try a more recent date.");
                            realYear = false;
                        }
                    }
                } while (realYear == false);

                monthNum = 0;
                string month;
                bool realMonth = false;
                do
                {
                    Console.Write("What month were you born? ");
                    month = Console.ReadLine();
                    realMonth = int.TryParse(month, out monthNum);
                    if (realMonth == false)
                    {
                        Console.Write("That doesn't seem like a real month, try the number of the month (ie 3 for March).\n");
                    }
                } while (monthNum > 12 || monthNum < 1 && realMonth == false);

                bool realDay = false;

                string day = "0";
                do
                {
                    Console.Write("What day were you born? ");
                    day = Console.ReadLine();
                    realDay = int.TryParse(day, out dayNumber);
                    if (realDay == false)
                    {
                        Console.WriteLine("That doesn't seem like a real day, lets try again.");
                    }

                } while (realDay == false);

                birthdayString = month + "/" + day + "/" + year;



                realBirthday = DateTime.TryParse(birthdayString, out birthday);
                if (realBirthday == false)
                {
                    Console.WriteLine("Sorry, that doesn't seem like a real birthday.  How about we try it again?");
                }

            } while (realBirthday == false);

            TimeSpan age = DateTime.Now.Subtract(birthday);
            string totalDaysString = age.TotalDays.ToString();
            int totalDays = Convert.ToInt32(double.Parse(totalDaysString))-1;
            int totalYears = (int)totalDays / 365;
            DateTime leapCheck = DateTime.Parse("2/29/2016");
            int i;
            
            if (birthday >= leapCheck)
            {
                for (i = 4; i < totalYears; i+=4)
                {
                    totalDays += 1;
                }
            }
            DateTime weirdException = DateTime.Parse("10/15/2015");
            if (birthday == weirdException)
            {
                Console.WriteLine("Happy birthday little one!");
            }
              
            if(totalDays%365.25 == 0)
            {
                Console.WriteLine("Happy birthday!");
            }

            Console.Write("Days old:");
            Console.WriteLine(totalDays);

            Console.Write("Years old: ");
            Console.WriteLine(totalYears);


            Console.ReadKey();

        }
    }
}
