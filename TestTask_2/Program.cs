using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_2
{
    internal class Program
    {
        static uint[] CommonDivisorInArray(uint[] array)
        {
            List<uint> list1 = new List<uint>();

            for (uint divisor = array.Min(); divisor > 0; divisor--)
            {
                if (array.Min() % divisor == 0)
                {
                    list1.Add(divisor);
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    if (array[i] % list1[j] != 0)
                    {
                        list1.Remove(list1[j]);
                    }
                }
            }
            list1.Remove(1);
            list1.Sort();
            return list1.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива\n");

            uint sizeArray = uint.Parse(Console.ReadLine());
            uint[] myArray = new uint[sizeArray];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Введите элемент массива\n");
                myArray[i] = uint.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("Заданный массив: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            uint[] newArray = CommonDivisorInArray(myArray);

            Console.Write("\nОбщие делители: ");

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
