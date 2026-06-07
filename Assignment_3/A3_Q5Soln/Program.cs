namespace A3_Q5Soln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supervisor s = new Supervisor();
            s.Accept();
            s.Print();
            Console.WriteLine(s.ToString());
        }
    }
}
