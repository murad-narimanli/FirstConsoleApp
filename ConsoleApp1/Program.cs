using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            int a = 13;

            if (a % 2 > 0)
            {
                Console.WriteLine("Yes");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("Melumati duzgun daxil edin");
            }


            //task2
            int i = 63;

            switch (i)
            {
                case int n when (n <= 100 && n >= 91):
                    Console.WriteLine("A");
                    break;
                case int n when (n <= 90 && n >= 81):
                    Console.WriteLine("B");
                    break;
                case int n when (n <= 80 && n >= 71):
                    Console.WriteLine("C");
                    break;
                case int n when (n <= 70 && n >= 61):
                    Console.WriteLine("D");
                    break;
                case int n when (n <= 60 && n >= 51):
                    Console.WriteLine("E");
                    break;
                case int n when (n <= 50 && n >= 0):
                    Console.WriteLine("F");
                    break;
                case int n when (n < 0 || n > 0):
                    Console.WriteLine("Bal cedveline uygun deyil");
                    break;
                default:
                    Console.WriteLine("Not Known");
                    break;
            }

            Console.ReadKey();
        }
    }
}
