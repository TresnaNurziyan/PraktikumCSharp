using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream
{
    class ReadWrite
    {
        static void baca(string fname)
        {
            try
            {
                StreamReader sr = new StreamReader(fname);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("");
                sr.Close();
            }
            catch(FileNotFoundException e)
            {
                e.Message.ToString();
            }
        }

        public static void Main()
        {
            Console.WriteLine("Masukan nama file teks: ");
            string fname = Console.ReadLine();
            baca(fname);

            Console.Write("Untuk berhenti tekan \"Esc\", untuk melanjutkan tekan tombol lainnya\n");

            ConsoleKeyInfo cki = Console.ReadKey();
            while(cki.Key != ConsoleKey.Escape)
            {
                StreamWriter sw = new StreamWriter(fname, true, Encoding.ASCII);
                string NextLine = Console.ReadLine();
                sw.Write(NextLine);
                sw.Close();

                Console.WriteLine("\nBerhasil menambahkan satu baris");
                Console.WriteLine("Isi file saat ini: ");
                baca(fname);
                cki = Console.ReadKey();
            }
        }
    }
}
