using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Kalkulator
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }

        static void info()
        {
            Console.WriteLine("\n Tekan \"Esc\" untuk berhenti, atau tekan tombol lain untuk melanjutkan\n");
        }

        static void Main()
        {
            info();
            ConsoleKeyInfo cki = Console.ReadKey();
            while (cki.Key != ConsoleKey.Escape)
            {
                try
                {
                    Console.Write("Masukan angka pertama :  ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Masukan angkan kedua : ");
                    double b = double.Parse(Console.ReadLine());

                    double totalBagi = SafeDivision(a, b);
                    double totalKali = a * b; 
                    double totalTambah = a + b;
                    double totalKurang = a - b;

                    Console.WriteLine("Total Bagi : {0}\nTotal Kali : {1}\nTotal Tambah : {2}\nTotal Kurang : {3}", totalBagi, totalKali, totalTambah, totalKurang);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nException Message: {0}", ex.Message);
                    Console.WriteLine("Exception stack trace: {0}", ex.StackTrace);
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    info();
                    cki = Console.ReadKey();
                }
            }
        }
    }
}
