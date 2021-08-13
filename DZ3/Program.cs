using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 90;
            var b = 45;
            var c = 10;

            var sr = b;
            var max = b;
            var min = b;

            if (a >= b)  //находим макс знач 
                max = a;
            if (max < c)
                max = c;

            if (a < b)  //находим мин знач
                min = a;
            if (min > c)
                min = c;

            if (b > min && b < max) 
                sr = b;
            if (a > min && a < max)
                sr = a;
            if (c > min && c < max)
                sr = c;

            a = max;
            b = sr;
            c = min;
            Console.WriteLine($"{a}, {b}, {c}");
            
        }
    }
}
