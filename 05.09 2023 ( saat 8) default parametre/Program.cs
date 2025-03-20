using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._09_2023___saat_8__default_paramet
{
    internal class Program
    {
        static void SelamVer(string isim = "Dünya")
        {
            Console.WriteLine("Merhaba, " + isim + "!");
        }

        static void Main()
        {
            // Metot çağrılabilir ve isim belirtilmeden çağrılabilir
            SelamVer(); // Varsayılan olarak "Dünya" kullanılacak
            SelamVer("Ahmet"); // Belirli bir isim kullanılacak
        }
    }
}
}
