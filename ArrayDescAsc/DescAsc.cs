using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDescAsc
{
    class DescAsc
    {
        static void Main(string[] args)
        {
            int[] angka = new int[10];

            for(int i = 0; i < angka.Length; i++)
            {
                Console.Write("Masukan angka : ");
                angka[i] = int.Parse(Console.ReadLine());
            }

            for(int x = 0; x < 10; x++)
            {
                for(int z = 0; z < 10 - 1; z++)
                {
                    if(angka[z] < angka[z + 1])
                    {
                        int tamp = angka[z];
                        angka[z] = angka[z + 1];
                        angka[z + 1] = tamp;
                    }
                }
            }
            for(int y = 0; y < 10; y++)
            {
                Console.WriteLine(angka[y]);
            }
            Console.ReadLine();
        }
    }
}
