using System;

namespace DZ3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var discount3 = 0.03;
            var discount5 = 0.05;
            var pAmount1 = 500;
            var pAmount2 = 1000;
            Console.WriteLine("Ввидите сумму");
            var summAmount = Convert.ToInt32(Console.ReadLine());

            if (summAmount > pAmount1 && summAmount < pAmount2)
            {
                var sum = summAmount * discount3;
                Console.Write($"Сумма к оплате с учётом 3% скидкой составляет {summAmount - sum}");
            }
            else if (summAmount > pAmount2)
            {
                var sum = summAmount * discount5;
                Console.Write($"Сумма к оплате с учётом 5% скилкой составляет {summAmount - sum}");
            }
            else
            {
                Console.Write($"Сумма покупки без скидки= {summAmount}");
            }
            
        }
    }
}
