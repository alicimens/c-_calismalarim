using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beden_kitle_endeksi__7_12_2023_gece_2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen boyunuzu girin");
            string boy = Console.ReadLine();
            int boy2 = int.Parse(boy);


            Console.WriteLine("lütfen kilonuzu girin");
            string kilo = Console.ReadLine();
            int kilo2 = int.Parse(kilo);

            int sonuc = kilo2 / (boy2 * boy2);


           if (sonuc <= 18)
            {

                Console.WriteLine("zayıf ");
                Console.ReadLine();
            }
            else if (sonuc > 18 && sonuc < 25)
            {

                Console.WriteLine("normal");
                Console.ReadLine();
            }

            else if (sonuc > 25)
            {
                Console.WriteLine("obez");
                Console.ReadLine();
            }
        }
    } }
