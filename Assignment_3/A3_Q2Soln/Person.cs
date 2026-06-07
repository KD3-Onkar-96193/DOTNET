using System;

namespace EmployeeLib
{
    public class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;

        // Default constructor
        public Person()
        {
            name = "";
            gender = false;
            birth = new Date();
            address = "";
        }

        // Parameterized constructor
        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Date Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Read-only Age property
        public int Age
        {
            get
            {
                return Date.CalculateAge(birth);
            }
        }

        // Accept method
        public void Accept()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Gender (true=Male/false=Female): ");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Birth Date:");
            birth.AcceptDate();

            Console.Write("Enter Address: ");
            address = Console.ReadLine();
        }

        // Print method
        public void Print()
        {
            Console.WriteLine("\n---- Person Details ----");
            Console.WriteLine("Name    : " + name);
            Console.WriteLine("Gender  : " + (gender ? "Male" : "Female"));
            Console.WriteLine("Birth   : " + birth.ToString());
            Console.WriteLine("Address : " + address);
            Console.WriteLine("Age     : " + Age);
        }

        // ToString override
        public override string ToString()
        {
            return $"Name: {name}, Gender: {(gender ? "Male" : "Female")}, " +
                   $"Birth: {birth}, Address: {address}, Age: {Age}";
        }
    }
}