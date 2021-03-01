using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mintemp, maxtemp;
            double middletemp;

            Console.WriteLine("please enter the maximum temprture:");
            maxtemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the munimum temprture:");
            mintemp = Convert.ToInt32(Console.ReadLine());

            middletemp = (mintemp + maxtemp) /2;

            Console.WriteLine(" The middle tempruture is " + mintemp +" degree ");
            Console.ReadKey();





        }
    }
}
