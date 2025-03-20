using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._09._2023__array_çok_boyutlu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 boyutlu bir dizi tanımlama
            int[,] matris = new int[3, 3];

            // Değer atama
            matris[0, 0] = 1;
            matris[0, 1] = 2;
            matris[0, 2] = 3;
            matris[1, 0] = 4;
            matris[1, 1] = 5;
            matris[1, 2] = 6;
            matris[2, 0] = 7;
            matris[2, 1] = 8;
            matris[2, 2] = 9;

            // Değerlere erişim
            int deger = matris[1, 1]; // matrisin 1. satır, 1. sütunundaki değeri alır (5)

            // Matrisi döngü ile gezme
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
