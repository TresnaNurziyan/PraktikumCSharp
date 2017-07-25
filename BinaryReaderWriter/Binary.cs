using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace BinaryReaderWriter
{
    class Binary
    {
        void Write()
        {
            int[] a = new int[10];
            for(int x = 0; x < 10; x++)
            {
                Console.Write("Masukan angka: ");
                int angka = int.Parse(Console.ReadLine());
                a[x] = angka;
            }
            using(BinaryWriter binWriter = new BinaryWriter(File.Open("file.bin", FileMode.Create)))
            {
                foreach(int i in a)
                {
                    binWriter.Write(i);
                    Console.WriteLine("Berhasil menulis: {0} pada file.bin", i);
                    Thread.Sleep(1000);
                }
            }
        }

        void Read()
        {
            using(BinaryReader binReader = new BinaryReader(File.Open("file.bin", FileMode.Open)))
            {
                int pos = 0;
                int length = (int)binReader.BaseStream.Length;
                while(pos < length)
                {
                    int v = binReader.ReadInt32();
                    //Console.WriteLine(v);
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Berhasil membaca: {0} pada file.bin", v);
                    pos += sizeof(int);
                    //if (v == 55)
                    //{
                    //    Thread.CurrentThread.Abort();
                    //}
                    Thread.Sleep(1000);
                }
            }
        }

        static void Main()
        {
            Binary bin = new Binary();
            bin.Write();
            bin.Read();

            Console.ReadKey();
        }
    }
}
