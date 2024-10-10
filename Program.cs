//***********************************************************
//* Практическая работа № 10                                 *
//* Выполнил: Кузин. Я. Н., группа 2ИСПд                    *
//* Задание: составить программу работы линейного алгоритма *
//***********************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Практическая работа №10");
                Console.WriteLine("Здравствуйте!");
                try
                {
                    int i, j;
                    int rows = 4;// строки
                    int cols = 4;// столбцы
                    // инициализация массива
                    int[,] mass = new int[rows, cols];
                    Random random = new Random();
                    for ( i = 0; i < rows; i++)
                    {
                        for (j = 0; j < cols; j++)
                        {
                            mass[i, j] = random.Next(-20, 21);
                        }
                        Console.WriteLine("Матрица: ");
                        for ( i = 0; i < rows; i++)
                        {
                            for ( j = 0; j < cols; j++)
                            {
                                Console.Write($"{mass[i, j],3}  ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\nСредние арифметические по строкам: ");
                        for ( i = 0; i < rows; i++)
                        {
                            int sum = 0;
                            int count = 0;
                            for ( j = 0; j < cols; j++)
                            {
                                if (mass[i, j] >= 0)
                                {
                                    sum += mass[i, j];
                                    count++;
                                }
                            }
                            if (count > 0)
                            {
                                double average = (double)sum / count;
                                Console.WriteLine($"Строка {i + 1}: {average: F2}");
                            }
                            else
                            {
                                Console.WriteLine($"Строка {i + 1}: Нет отрицательных элементов");
                            }
                        }
                    }
                }
                catch (IndexOutOfRangeException iOfREx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникла ошибка - {iOfREx.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (DivideByZeroException dByZEx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникла ошибка - {dByZEx.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.ReadKey();

            }
        }
    }
}
