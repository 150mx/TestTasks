using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_1
{
    internal class Program
    {
        static string computerCount(uint count)
        {
            string sumComputer = count.ToString();
            char lastChar = sumComputer.Last();

            if (sumComputer.Length > 1)
            {
                char PreLastChar = sumComputer[sumComputer.Length - 2];
                switch (PreLastChar)
                {
                    case '1':
                        sumComputer += " комьютеров";
                        break;
                    default:
                        switch (lastChar)
                        {
                            case '1':
                                sumComputer += " комьютер";
                                break;
                            case '2':
                            case '3':
                            case '4':
                                sumComputer += " комьютера";
                                break;
                            case '0':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                sumComputer += " компьютеров";
                                break;
                        }
                        return sumComputer;
                }
                return sumComputer;
            }
            else
            {
                switch (lastChar)
                {
                    case '1':
                        sumComputer += " комьютер";
                        break;
                    case '2':
                    case '3':
                    case '4':
                        sumComputer += " комьютера";
                        break;
                    case '0':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        sumComputer += " компьютеров";
                        break;
                }
                return sumComputer;
            }
        }
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Введите число компьютеров\n");
                try
                {
                    uint Count = uint.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(computerCount(Count));
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("вы ввели неверное значение");

                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
