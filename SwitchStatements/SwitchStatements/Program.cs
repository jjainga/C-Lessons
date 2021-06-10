using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Select a number from 1 - 7: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetDay(num1));

            Console.ReadLine();
        }

        static string GetDay(int weekday)
        {
            string dayName;

            switch (weekday)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "There are not " + weekday + " days in the week!";
                    break;
            }

            
            return dayName;

        }
    }
}
