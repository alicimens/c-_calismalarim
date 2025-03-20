using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12_23_gece_10__pratik_proje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[10];
            int kullanıcıdeger;
            int çst = 0;
            int tst = 0;
            int kaçteksayi = 0;
            int kaççiftsayi = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("lütfen sayiyi gir ");
                kullanıcıdeger = Convert.ToInt32(Console.ReadLine());

                sayilar[i] = kullanıcıdeger;

            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j]%2 == 0)
                {
                    kaççiftsayi++;
                    çst += sayilar[j];

                }
                else 
                {
                    kaçteksayi++;
                    tst += sayilar[j];
                }
            }

            Console.WriteLine("çif sayiların toplamı" + çst);


            Console.WriteLine("tek  sayiların toplamı" + tst);
            

            if (çst > tst)
            {
                Console.WriteLine("çift sayıların toplamı daha büyük");
                
            }
            else  {

                Console.WriteLine("tek sayıların toplamı daha büyük");
               
            }
            Console.ReadLine();
        }
    }
}
