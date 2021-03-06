using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] mass = { { "Ali", "Ali@gmail.com" } , { "Ahmed", "Ahmed@gmail.com" },{"maxim" , "maxim@gmail.com" }, { "Alex" , "Alex@gmail.com"},{ "masha", "masha@gmail.com"} };

            Console.WriteLine("phone contacts:");
            for (int i = 0; i < mass.GetLength(0); i++) 
            {
                Console.WriteLine($"{mass[i, 0]}: {mass[i, 1]}");
            }
           
              

           
        }
    }
}