using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            String name;
            Double option;
            Console.WriteLine("Hi gamer, Tell me your nickname");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ". Welcome to the Guess Number");
            Console.WriteLine("Choose an Option!");
            Console.WriteLine("1) Easy level / 2) Middle Level / 3) Hard Level / 4) Exit");
            option = Convert.ToDouble(Console.ReadLine());
            if (option == 1)
            {
                double Rnumber = random.Next(1, 11);
                double attemps = 1;
                double number;
                Console.WriteLine("Welcome to the Easy level");
                while (attemps <= 3)
                {
                    Console.WriteLine("Tell me a number between 1 and 10, you have 3 attemps and this is your try: " + attemps);
                    number = Convert.ToDouble(Console.ReadLine());
                    if (number <= 10)
                    {
                        if (number == Rnumber)
                        {
                            Console.WriteLine("You got It!");
                            break;
                        }
                        else if (number < Rnumber)
                        {
                            Console.WriteLine("The number is higher");
                        }
                        else if (number > Rnumber)
                        {
                            Console.WriteLine("The number is lower");
                        }
                        attemps++;
                    }
                    else if (number > 10 && number <= 50)
                    {
                        Console.WriteLine("That number is not valid for this level.Better go to the Middle Level");
                    } else if (number > 50)
                    {
                        Console.WriteLine("That number is not valid for this level. Better go to the Hard Level");
                    }

                    if (attemps > 3)
                    {
                        Console.WriteLine("The number is: " + Rnumber);
                    }
                }
            } else if (option == 2)
            {
                double Rnumber = random.Next(1, 51);
                double attemps = 1;
                double number;
                Console.WriteLine("Welcome to the Middle level");
                while (attemps <= 5)
                {
                    Console.WriteLine("Tell me a number between 1 and 50, you have 5 attemps and this is your try: " + attemps);
                    number = Convert.ToDouble(Console.ReadLine());
                    if (number <= 50)
                    {
                        if (number == Rnumber)
                        {
                            Console.WriteLine("You got It!");
                            break;
                        }
                        else if (number < Rnumber)
                        {
                            Console.WriteLine("The number is higher");
                        }
                        else if (number > Rnumber)
                        {
                            Console.WriteLine("The number is lower");
                        }
                        attemps++;
                    }
                    else if (number > 50)
                    {
                        Console.WriteLine("That number is not valid for this level. Better go to the Hard Level");
                    }
                    if (attemps > 5)
                    {
                        Console.WriteLine("The number is: " + Rnumber);
                    }
                }
            } else if (option == 3)
            {
                double Rnumber = random.Next(1, 101);
                double attemps = 1;
                double number;
                Console.WriteLine("Welcome to the Middle level");
                while (attemps <= 8)
                {
                    Console.WriteLine("Tell me a number between 1 and 100, you have 8 attemps and this is your try: " + attemps);
                    number = Convert.ToDouble(Console.ReadLine());
                    if (number <= 100)
                    {
                        if (number == Rnumber)
                        {
                            Console.WriteLine("You got It!");
                            break;
                        }
                        else if (number < Rnumber)
                        {
                            Console.WriteLine("The number is higher");
                        }
                        else if (number > Rnumber)
                        {
                            Console.WriteLine("The number is lower");
                        }
                        attemps++;
                    }
                    else if (number > 100)
                    {
                        Console.WriteLine("The number is higher than 100");
                    }
                    if (attemps > 8)
                    {
                        Console.WriteLine("The number is: " + Rnumber);
                    }
                }
            } else if (option == 4)
            {
                Environment.Exit(0);
            }
            Console.Read();
        }
    }
}
