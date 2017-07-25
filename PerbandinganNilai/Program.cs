using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerbandinganNilai
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 0, b = 5; ((a < 5) && (b > 0)); b--, a++)
            {
                Console.WriteLine("{0} {1} {2}\t", a, (a > b ? '>' : '<'), b);

                Console.WriteLine(b == 0 ? "Perbandingan selesai" : "Perbandingan selanjutnya");
            }
            Console.ReadKey();
        }
    }
}
