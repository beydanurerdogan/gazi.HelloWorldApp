using System;

namespace OdevApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose december:\n1. 1-10  \n2. 1-30 \n3. 1-100 ");
            int aralik = int.Parse(Console.ReadLine());

            if (aralik == 1)
            {
                Console.WriteLine("You have 5 rights to guess!");

                Random rnd = new Random();
                int number = rnd.Next(1, 10);
                Console.WriteLine(number);
                int counter = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Guess the number:");
                    int tahmin = int.Parse(Console.ReadLine());
                    counter++;
                    if (tahmin == number)
                    {
                        Console.WriteLine("You won!");
                        break;
                    }
                    else if (counter < 5)
                    {
                        Console.WriteLine("Try again:");
                    }

                    else if (counter == 5)
                    {
                        Console.WriteLine("Your right has expired!");
                        break;
                    }

                    

                }


            }
            if (aralik == 2)
            {
                Console.WriteLine("You have 7 rights to guess!");

                Random rnd = new Random();
                int number = rnd.Next(1, 30);
                Console.WriteLine(number);
                int counter = 0;
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("Guess the number:");
                    int tahmin = int.Parse(Console.ReadLine());
                    counter++;
                    if (tahmin == number)
                    {
                        Console.WriteLine("You won!");
                        break;
                    }
                    else if (counter < 7)
                    {
                        Console.WriteLine("Try again:");
                    }

                    else if (counter == 7)
                    {
                        Console.WriteLine("Your right has expired!");
                        break;
                    }

                }


            }
            if (aralik == 3)
            {
                Console.WriteLine("You have 10 rights to guess!");

                Random rnd = new Random();
                int number = rnd.Next(1, 100);
                Console.WriteLine(number);
                int counter = 0;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Guess the number:");
                    int tahmin = int.Parse(Console.ReadLine());
                    counter++;
                    if (tahmin == number)
                    {
                        Console.WriteLine("You won!");
                        break;
                    }
                    else if (counter < 10)
                    {
                        Console.WriteLine("Try again:");
                    }

                    else if (counter == 10)
                    {
                        Console.WriteLine("Your right has expired!");
                        break;
                    }

                }


            }


        }
    }
}
