using System;

namespace codewars_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning execution...");
            ISolutionRunner solution = new CreatePhoneNumber();
            solution.Run();
            Console.ReadLine();
        }
    }
}
