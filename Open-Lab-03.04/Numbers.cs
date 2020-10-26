using System;

namespace Open_Lab_03._04
{
    public class Numbers
    {
        public string EvenOrOdd(int number)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
                Console.WriteLine("Even", number);
            else
                Console.WriteLine("Odd", number);
        }
    }
}
