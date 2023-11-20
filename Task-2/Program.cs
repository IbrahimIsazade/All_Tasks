namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Variables
            double a, b;
            string name, surename, fullname;

            // Body part
            name = "name";
            surename = "surename";
            fullname = $"{name} {surename}";
            Console.WriteLine(fullname);

            a = 18;
            b = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.ReadKey();
        }
    }
}