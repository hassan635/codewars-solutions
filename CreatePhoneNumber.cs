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
            StringBuilder phoneNumber = new StringBuilder();
            phoneNumber.Append("(");
            for (int i = 0; i < numbers.Length; i++)
            {
                if(i==3)
                { phoneNumber.Append(") "); }
                else if (i == 6) { phoneNumber.Append("-"); }

                phoneNumber.Append(numbers[i]);
            }
            return phoneNumber.ToString();
        }
    }
}
