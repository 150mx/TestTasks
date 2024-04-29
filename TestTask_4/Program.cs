using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_4
{
    internal class Program
    {
        static void multiplicationTable(uint number)
        {
            for (int q = 0; q <= number; q++)
            {
                if (q == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(q);
                }
                Console.Write("\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    if (j < 2)
                    {
                        Console.Write(i + 1);
                    }
                    else
                    {
                        Console.Write((i + 1) * j);
                    }
                    Console.Write("\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 9, до которого метод будет выводит таблицу умножения\n");

            uint number = uint.Parse(Console.ReadLine());

            Console.WriteLine();

            multiplicationTable(number);
            Console.ReadLine();
        }
    }
}
