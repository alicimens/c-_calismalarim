using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2023_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* string[] students =  new string[3];
            students[0] = "engin";
            students[1] = "derin";
            students[2] = "salih";
            */
           //string[] students = {"engin","derin","salih"};// bu yukardakinin  daha kısa hali
            string[] students = new []{"engin","derin","salih"};

            foreach (var student in students) // burayı sonra anlatacak
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
