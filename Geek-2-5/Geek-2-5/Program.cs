using System;

namespace Geek_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int tem = 0;
            string mon = null;

            
            for (int i = 0; i <= 12; i++)
            {
                

              

                Console.WriteLine(" Введите месяц Зимней природы :");
                mon = Console.ReadLine();
                Console.WriteLine("Ввидите Текщую Тембиратору");
                tem = Convert.ToInt32( Console.ReadLine());


                if (tem > 0)
                {
                    Console.WriteLine("Дождливая зима");
                    break;
                }

                else
                    Console.WriteLine("Не Правильный Вывод!!,Попробуйте ещё раз.");
                
                Console.ReadLine();
                

                

                  
                
                  
            }




        }
    }
}
