using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isInc = false;


            int[] mass = new int[4];
            Console.WriteLine("Введите 1-число");
            mass[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-число");
            mass[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3-число");
            mass[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 4-число");
            mass[3] = Convert.ToInt32(Console.ReadLine());

            int minValue = mass[0];
            for (int i = 0; i < mass.Length - 1; i++) //делаем тоже самое только для возрастающей последовательности
                if (mass[i] < mass[i + 1]) isInc = true;
                else
                {
                    isInc = false;
                    break;
                }

             if (mass[0] == mass[1] && mass[2] == mass[3] && mass[0]==mass[3])
            {
                var summ = mass[0] * mass[1] * mass[2] * mass[3];
                Console.Write($"произведение чисел = { summ }");
            }

            else if (!isInc)

            {
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] < minValue)
                    {
                        minValue = mass[i];
                    }

                }
                Console.WriteLine($"мин знач - {minValue}");//ес        }        }
                
            }
             else 
                //(isInc)
              {
                Console.WriteLine($"числа расположены по возрастанию");
                //isInc = false;
                //break;
            }
        }
    }

}