using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._09._2023_arrayleri_tekrar_yazmak_zorunda_kaldım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string[] students = new string[3];
             students[0] = "ali";
             students[1] = "emir";
             students[2] = "hasan";
            */
            //string[] students2 = new  [] {"ali", "emir", "hasan"}; // bu üsttekinin kısa hali

            string[] students2 = { "ali", "emir", "hasan" }; // bu da kısa hali

            foreach (var student in students2) // foreach ı sonra öğrenecez ama students2 ye dikkat et
            {

                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
