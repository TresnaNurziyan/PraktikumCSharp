using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Thread
{
    class Stream
    {
        async void Salin()
        {
            string StartDirectory = @"C:\Users\tresna\Documents\Thread\start";
            string EndDirectory = @"C:\Users\tresna\Documents\Thread\end";

            foreach(string filename in Directory.EnumerateFiles(StartDirectory))
            {
                Console.WriteLine("Isi folder: " + filename);

                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    using (FileStream DestinationStream = File.Create(EndDirectory + filename.Substring(filename.LastIndexOf('\\'))))
                    {
                        await SourceStream.CopyToAsync(DestinationStream);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Stream a = new Stream();
            a.Salin();

            Console.ReadKey();
        }
    }
}
