using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._09._2023_saat_11_video_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 88;
            int y = 78;
            var result = Add3(x,y); // buraya bir de 22. satıra "ref" koyarak  x in değerini değiştirebiliyoruz... yani methodun içindeki değeri dışarı aktarabiliyoruz
            Console.WriteLine(result);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        static int  Add3 ( int a , int b)
        {
            a = 100;
            return a + b;

        }
    }
}
