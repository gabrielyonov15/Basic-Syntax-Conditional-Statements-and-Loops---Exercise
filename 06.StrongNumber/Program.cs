using System.Runtime.ConstrainedExecution;

namespace _6StrongNu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int sumOfFactorials = 0;
            while (number != 0)
            {
                int digit = number % 10;
                int factorial = 1;
                for (int i = 2; i <= digit; i++)
                {
                    factorial *= i;
                }
                sumOfFactorials += factorial;
                number /= 10;
            }
            if (sumOfFactorials == originalNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}