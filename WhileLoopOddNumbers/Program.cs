using System;

namespace WhileLoopOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            while (x < 26)
            {
                if(x % 2 == 1)
                {
                    Console.WriteLine($"The cube of the {x} is {x *x*x}");

                }

                x++;
            }
        }
    }
}
