﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_07_2023_metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2(28, 30);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Add()
        {

            Console.WriteLine("added");
        }
        static int  Add2(int number1, int number2)
        {
            int result = number1 + number2;
           return result;

        }
    }
}
