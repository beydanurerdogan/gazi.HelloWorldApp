using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace OdevApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose december:\n1. 1-10  \n2. 1-30 \n3. 1-100 ");
            int aralik = int.Parse(Console.ReadLine());
            int counter = 0;
            int n1 = 1;
            int n2 = 10;
            int n3 = 30;
            int n4 = 100;            
            Random rnd = new Random();
            int number=rnd.Next();

            if (aralik == 1)
            {
                Console.WriteLine("You have 5 rights to guess!");
                number = rnd.Next(n1, n2);                
                counter++;
            }   
            else if (aralik == 2)
            {
                Console.WriteLine("You have 7 rights to guess!");
                number = rnd.Next(n1, n3);
                counter++;
            }
            else if (aralik == 3)
            {
                Console.WriteLine("You have 10 rights to guess!");
                number = rnd.Next(n1, n4);
                counter++;
            }



        }
    }
}
