﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Month1 = DateTime.Now.Month;

            //Expression 

            switch (Month1)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındsanız:!");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız:");
                    break;
                case 3:
                    Console.WriteLine("Nisan Ayındasınız:");
                    break;
                case 4:
                    Console.WriteLine("Mart Ayındasınız:");
                    break;
                
                default:
                    Console.WriteLine("Yanlış Veri girdiniz:");
                break;
            }
            switch (Month1)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Ayındasınız:");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlk Bahar Ayındasınız:");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayındasınız:");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Son Bahar Ayındasınız:");
                    break;

                

                default:
                break;
            }
        }
    }
}