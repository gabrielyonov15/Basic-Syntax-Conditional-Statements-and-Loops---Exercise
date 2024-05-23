namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalSum = 0;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                sum = ((pricePerCapsule * days) * capsulesCount);
                totalSum += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:F2}");
            }
            Console.WriteLine($"Total: ${totalSum:F2}");
        }
    }
}
