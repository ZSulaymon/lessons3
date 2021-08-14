using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            //nt.TryParse(Console.ReadLine(), out var arrSize);
            //int[] arr = new int[arrSize];
            int[] arr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Введите чило для индекса {i+1}:");
                int.TryParse(Console.ReadLine(), out var number);
                arr[i] = number;
            }

            //int.TryParse(Console.ReadLine(), out var arrSize);
            //int.TryParse(Console.ReadLine(), out var arrSize);
            //int.TryParse(Console.ReadLine(), out var arrSize);


            //var a = 0;
            //var b = 0;
            //var c = 0;

            //for (int i = 0; i < arrSize; i++)
            //{
            //    if (i == 0)
            //    {
            //        a = arr[i];
            //    }
            //    if (i == 1)
            //    {
            //        b = arr[i];
            //    }
            //    if (i == 2)
            //    {
            //        c = arr[i];
            //    }

            //}

            var a = arr[0];
            var b = arr[1];
            var c = arr[2];


            var sr = b;
            var max = b;
            var min = b;



            if (a >= b)  //находим макс знач 
                max = a;
            if (max <= c)
                max = c;

            if (a <= b)  //находим мин знач
                min = a;
            if (min >= c)
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
