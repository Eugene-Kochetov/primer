using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
 int M2, M5, M10, R, MAX, dat, res, i, N;
            M2 = 0;
            M5 = 0;
            M10 = 0;
            MAX = 0;
            
            try
            {
            Console.WriteLine("Введите n: ");
            N = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < N; i++)
                {




                    Console.WriteLine("Введите x: ");
                    dat = Convert.ToInt32(Console.ReadLine());
                    if (dat % 2 == 0 && dat % 5 > 0 && dat > M2)
                    {
                        M2 = dat;
                    }
                    if (dat % 5 == 0 && dat % 2 > 0 && dat > M5)
                    {
                        M5 = dat;
                    }
                    if (dat % 10 == 0 && dat > M10)
                    {
                        if (M10 > MAX)
                        {
                            MAX = M10;
                            M10 = dat;
                        }
                        else if (dat > MAX)
                        {
                            MAX = dat;
                        }
                    }
                }
                Console.WriteLine("Введите R: ");
                R = Convert.ToInt32(Console.ReadLine());
                if (M2 * M5 < M10 * MAX)
                {
                    res = M10 * MAX;
                }
                else
                {
                    res = M2 * M5;
                    Console.WriteLine($"Вычисленное контрольное значение: {res}");
                }
                if (R == res)
                {
                    Console.WriteLine("Контроль пройден");
                }
                else
                {
                    Console.WriteLine("Контроль не пройден");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено нечисловое значение!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"исключение: {ex.Message}");
            }
 
 

     }
   }
 }
