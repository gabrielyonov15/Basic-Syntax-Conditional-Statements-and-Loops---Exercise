namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            int additionalLightsabers = (int)Math.Ceiling(countOfStudents * 0.1);
            int freeBelts = countOfStudents / 6;
            int beltsToPay = countOfStudents - freeBelts;
            double totalCost = (priceOfLightsabers * (countOfStudents + additionalLightsabers)) +
                               (priceOfRobes * countOfStudents) +
                               (priceOfBelts * beltsToPay);
            if (amountOfMoney >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                double neededMoney = totalCost - amountOfMoney;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
