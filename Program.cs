using System;

namespace Lab21Date
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Date newDate = new Date(7, 4, 2004);
            Console.WriteLine($"Initial date is: {newDate.DisplayDate()}");

            newDate.Month = 11;
            newDate.Day = 1;
            newDate.Year = 2003;

            Console.WriteLine($"Date with new values is: {newDate.DisplayDate()}");
        }
    }
}
