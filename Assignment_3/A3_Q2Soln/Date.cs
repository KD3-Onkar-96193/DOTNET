
using System;

namespace EmployeeLib
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        // Default constructor
        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }

        // Parameterized constructor
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        // Properties
        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        // Accept date
        public void AcceptDate()
        {
            Console.Write("Enter Day: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Month: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        // Print date
        public void PrintDate()
        {
            Console.WriteLine($"{day}/{month}/{year}");
        }

        // Static method to calculate Age
        public static int CalculateAge(Date birth)
        {
            DateTime today = DateTime.Now;

            int age = today.Year - birth.Year;

            if (today.Month < birth.Month ||
               (today.Month == birth.Month && today.Day < birth.Day))
            {
                age--;
            }

            return age;
        }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}