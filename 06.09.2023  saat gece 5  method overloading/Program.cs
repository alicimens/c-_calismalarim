using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _06._09._2023__saat_gece_5__method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Multiplay(2, 4));
            Console.WriteLine(Multiplay(2, 4, 5));
    
            Console.WriteLine(afg (1,2,3,4,5,6,7));
            Console.ReadLine();

        }
        static int Multiplay(int a, int b)
        {
            return a * b;
        }
        static int Multiplay(int a, int b, int c) // bak burada yeni bir method tanımlamadan 3. bir int değeri verebildik işte buna method overloading deniyor
        {
            return a * b * c;

        }
        // peki 100 tane sayıyı toplamak istediğimiz zaman ise şunu yapıyoruz

        static int afg(params int[] numbers)
        {


            return numbers.Sum();
        }
    }
}
