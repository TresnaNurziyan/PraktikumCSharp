using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ThreadDownload
{
    class Download
    {
        static void Main(string[] args)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);
            string remoteUri = "https://wallpaperscraft.com/image/";
            string filename = "dota_2_traxe_drow_ranger_art_milimalism_97328_1366x768.jpg", myStringWebResource = null;

            WebClient webClient = new WebClient();

            try
            {
                myStringWebResource = remoteUri + filename;
                Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .........\n\n", filename, myStringWebResource);

                webClient.DownloadFile(myStringWebResource, filename);
                Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", filename, myStringWebResource);
                //Downloading file saved in project folder debug
                Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + path);
            }
            catch(WebException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
