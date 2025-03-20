using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._07._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            Add2(20,30);
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
                
        }
        static int Add2(int number1 , int number2)
        {
            return number1 + number2;
        }

    }
}
