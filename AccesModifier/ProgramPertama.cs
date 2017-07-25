using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifier
{
    class ProgramPertama
    {
        void swapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        void swapByReference(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Main(String[] args)
        {
            int a = 1;
            int b = 5;

            ProgramPertama programPertama = new ProgramPertama();

            Console.WriteLine("nilai x: " + a);
            Console.WriteLine("nilai y: " + b);

            programPertama.swapByValue(a, b);
            Console.WriteLine("nilai x by val setelah swap: " + a);
            Console.WriteLine("nilai y by val setelah swap: " + b);

            programPertama.swapByReference(ref a, ref b);
            Console.WriteLine("nilai x by ref setelah swap: " + a);
            Console.WriteLine("nilai y by ref setelah swap: " + b);

            Console.ReadKey();
        }
    }
}
