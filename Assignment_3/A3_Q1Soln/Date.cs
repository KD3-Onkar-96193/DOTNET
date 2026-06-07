using System;

namespace EmployeeLib
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void AcceptDate()
        {
            Console.Write("Enter Day: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Month: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Date: " + day + "/" + month + "/" + year);
        }

        public bool IsValid()
        {
            if (year < 1)
                return false;

            if (month < 1 || month > 12)
                return false;

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30,
                                  31, 31, 30, 31, 30, 31 };

            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            if (isLeap && month == 2)
            {
                return day >= 1 && day <= 29;
            }

            return day >= 1 && day <= daysInMonth[month - 1];
        }

        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
    }
}