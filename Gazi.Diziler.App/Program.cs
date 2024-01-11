namespace Gazi.Diziler.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diziler-Array
            //int number = 10;
            //int[]numbers = new int[3];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            // numbers[3] = 40;//IndexOutOfRangeException

            //int[] numbers = { 50,20,30};

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Array.Sort(numbers);
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Console.WriteLine("How many names do you want to sort:");
            //int count=int.Parse(Console.ReadLine());           
            //string[]names =new string[count]; 

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"Enter{i+1}.Name");
            //    names[i] = Console.ReadLine();
            //}
            //Array.Sort(names);
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"{i+1}-{names[i]}");
            //}


            //Console.WriteLine("How many numbers do you want to sort?");
            //int count = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter starting number:");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number:");
            //int end = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int[] numbers = new int[count];
            //for (int i = 0; i < count; i++)
            //{
            //    numbers[i] = rnd.Next(start, end);
            //}
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            Console.WriteLine("How many numbers do you want to sort?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number:");
            int end = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            HashSet<int> numbers = new HashSet<int>();

            while (numbers.Count < count)
            {
                int cnumber = rnd.Next(start, end);
                numbers.Add(cnumber);
            }

            int[] numberss = numbers.ToArray();
            Array.Sort(numberss);

            for (int i = 0; i < numberss.Length; i++)
            {
                Console.WriteLine(numberss[i]);
            }
        }
    }
}
//numbers=referans->Heap bölgesindeki değerlerin adresini tutan yapılar
//Index:Dizi elamanlarına ulaşmak için kullanılan sayılar.Indexler 0 dan başlar.
//ÖDEV
//Generated random numbers must be unique