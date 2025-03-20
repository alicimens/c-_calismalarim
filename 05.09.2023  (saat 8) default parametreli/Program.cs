using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._09._2023___saat_8__default_parametreli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SelamVer();
            SelamVer("Ahmet");
            Console.ReadLine();
        }

        static void SelamVer(string isim = "Dünya")
        {
            Console.WriteLine("Merhaba, " + isim + "!");
           


        }
       

    }
}
