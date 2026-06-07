using System;

namespace A3_Q3Soln.Models
{
    public class Person
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime Birth { get; set; }
        public string Address { get; set; }

        public Person()
        {
            Name = "";
            Gender = true;
            Birth = DateTime.Now;
            Address = "";
        }

        public Person(string name, bool gender, DateTime birth, string address)
        {
            Name = name;
            Gender = gender;
            Birth = birth;
            Address = address;
        }

        public virtual void Accept()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Gender (true=Male, false=Female): ");
            Gender = bool.Parse(Console.ReadLine());

            Console.Write("Enter Birth Date (yyyy-mm-dd): ");
            Birth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {(Gender ? "Male" : "Female")}");
            Console.WriteLine($"Birth: {Birth.ToShortDateString()}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}