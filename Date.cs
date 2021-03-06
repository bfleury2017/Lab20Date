﻿using System;
namespace Lab21Date
{
    public class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public string DisplayDate() => $"{Month}/{Day}/{Year}";
    }
}
