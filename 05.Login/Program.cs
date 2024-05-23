namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string username = Console.ReadLine();
                string reversedUsername = new string(username.Reverse().ToArray());
                bool loggedIn = false; 
                string password = Console.ReadLine();
                if (password == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    loggedIn = true;
                }
                else
                {
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        password = Console.ReadLine();
                        if (password == reversedUsername)
                        {
                            Console.WriteLine($"User {username} logged in.");
                            loggedIn = true; 
                            break;
                        }
                    }
                }
                if (!loggedIn) 
                {
                    Console.WriteLine($"User {username} blocked!");
                }
            }
        }
    }
  
