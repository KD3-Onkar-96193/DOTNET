using System;

struct Student
{
    private string name;
    private bool gender;
    private int age;
    private int std;
    private char div;
    private double marks;

    
    public Student()
    {
        name = "";
        gender = false;
        age = 0;
        std = 0;
        div = 'A';
        marks = 0.0;
    }

    public Student(string name, bool gender, int age, int std, char div, double marks)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.std = std;
        this.div = div;
        this.marks = marks;
    }

    public void SetName(string name) { this.name = name; }
    public string GetName() { return name; }

    public void SetGender(bool gender) { this.gender = gender; }
    public bool GetGender() { return gender; }

    public void SetAge(int age) { this.age = age; }
    public int GetAge() { return age; }

    public void SetStd(int std) { this.std = std; }
    public int GetStd() { return std; }

    public void SetDiv(char div) { this.div = div; }
    public char GetDiv() { return div; }

    public void SetMarks(double marks) { this.marks = marks; }
    public double GetMarks() { return marks; }

    public void AcceptDetails()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Gender (true for Male / false for Female): ");
        gender = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Standard: ");
        std = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Division: ");
        div = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter Marks: ");
        marks = Convert.ToDouble(Console.ReadLine());
    }

    public void PrintDetails()
    {
        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine("Name   : " + name);
        Console.WriteLine("Gender : " + (gender ? "Male" : "Female"));
        Console.WriteLine("Age    : " + age);
        Console.WriteLine("Std    : " + std);
        Console.WriteLine("Div    : " + div);
        Console.WriteLine("Marks  : " + marks);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();

        s1.AcceptDetails();
        s1.PrintDetails();
    }
}