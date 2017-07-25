using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BangunRuangThread
{
    class Program
    {
        static void Main(string[] args)
        {
            int pb;
            int lb;
            int tb;

            Console.Write("Masukan panjang balok: ");
            pb = int.Parse(Console.ReadLine());
            Console.Write("Masukan lebar balok: ");
            lb = int.Parse(Console.ReadLine());
            Console.Write("Masukan tinggi balok: ");
            tb = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Thread.Sleep(2000);

            int pkl = pb * lb;
            int pklt = pkl * tb;

            Console.WriteLine("{0} x {1} = {2}", pb, lb, pkl);
            Thread.Sleep(2000);
            Console.WriteLine("{0} x {1} = {2}", pkl, tb, pklt);
            Thread.Sleep(2000);
            Console.WriteLine("Volume balok adalah " + pklt);

            Console.ReadLine();
        }
    }
}
