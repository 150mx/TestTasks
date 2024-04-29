using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_3
{
    internal class Program
    {
        static uint[] primeNumbersArray(uint firstValue, uint lastValue)
        {
            uint[] array = new uint[lastValue - firstValue + 1];
            List<uint> list1 = new List<uint>();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = firstValue;
                if (array[i] > 1)
                {
                    list1.Add(array[i]);
                }
                firstValue++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
                    {
                        list1.Remove(array[i]);
                    }
                }
            }
            return list1.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");

            uint firstValue = uint.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите последнее число число");

            uint lastValue = uint.Parse(Console.ReadLine());

            Console.WriteLine("\nМассив простых чисел:\n");

            uint[] newPrimeArray = primeNumbersArray(firstValue, lastValue);

            for (int i = 0; i < newPrimeArray.Length; i++)
            {
                Console.Write(newPrimeArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
