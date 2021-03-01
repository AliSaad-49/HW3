using System;

namespace geek_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=10;i++)
            {
                Console.WriteLine(" Ввидите число: ");

                int a = Convert.ToInt32(Console.ReadLine());

                if (i % 2 == 0)
                {
                    Console.WriteLine(" Чётное Число");
                    Console.ReadLine();
                    break;
                    
                }

                else
                    Console.WriteLine("Ощибка!!, Вы ввели не чётное число");
                Console.ReadLine();
            }
        }
    }
}
