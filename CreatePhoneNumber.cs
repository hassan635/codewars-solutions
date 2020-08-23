using System;
using System.Text;

namespace codewars_solutions
{
    public class CreatePhoneNumber : ISolutionRunner
    {
        public CreatePhoneNumber()
        {
        }

        public void Run()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(CreatePhoneNumberFunc(numbers));
        }

        public string CreatePhoneNumberFunc(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}
