namespace _3Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double price1 = 0;
            if (dayOfWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    if (countPeople >= 30)
                    {
                        price = (8.45 * countPeople) * 0.15;
                        price1 = (8.45 * countPeople) - price;
                        Console.WriteLine($"Total price: {price1:f2}");
                    }
                    else
                    {
                        price = (8.45 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
                else
                     if (groupType == "Business")
                {
                    if (countPeople >= 100)
                    {
                       price1= countPeople - 10;
                        price = (10.90 * price1);
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        price = (10.90 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
                else
                      if (groupType == "Regular")
                {
                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        price = (15 * countPeople) * 0.05;
                        price1 = (15 * countPeople) - price;
                        Console.WriteLine($"Total price: {price1:F2}");
                    }
                    else
                    {
                        price = (15 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
            }
            else
            if (dayOfWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    if (countPeople >= 30)
                    {
                        price = (9.80 * countPeople) * 0.15;
                        price1 = (9.80 * countPeople) - price;
                        Console.WriteLine($"Total price: {price1:f2}");
                    }
                    else
                    {
                        price = (9.80 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
                else
                     if (groupType == "Business")
                {
                    if (countPeople >= 100)
                    {
                        price1 = countPeople - 10;
                        price = (15.60 * price1);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        price = (15.60 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
                else
                      if (groupType == "Regular")
                {
                    if (countPeople >= 10 && countPeople <=20)
                    {
                        price = (20 * countPeople) * 0.05;
                        price1 = (20 * countPeople) - price;
                        Console.WriteLine($"Total price: {price1:f2}");
                    }
                    else
                    {
                        price = (20 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
            }
            else
                    if (dayOfWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    if (countPeople >= 30)
                    {
                        price = (10.46 * countPeople) * 0.15;
                        price1 = (10.46 * countPeople) - price;
                        Console.WriteLine($"Total price: {price1:f2}");
                    }
                    else
                    {
                        price = (10.46 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
                else
                     if (groupType == "Business")
                {
                    if (countPeople >= 100)
                    {
                        price1 = countPeople - 10;
                        price = (16 * price1);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        price = (16 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
                else
                      if (groupType == "Regular")
                {
                    if (countPeople >= 10 && countPeople <= 20)
                    {
                        price = (22.50 * countPeople) * 0.05;
                        price1 = (22.50 * countPeople) - price;
                        Console.WriteLine($"Total price: {price1:f2}");
                    }
                    else
                    {
                        price = (22.50 * countPeople);
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                }
            }
        }
    }
}
   
