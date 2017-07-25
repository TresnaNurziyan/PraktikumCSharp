using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class ProgramKedua
    {
        static void Main(String[] args)
        {
            ProgramPertama pu = new ProgramPertama();

            pu.x = 3;
            pu.y = 5;

            Console.WriteLine("x = {0}, y = {1}", pu.x, pu.y);

            Console.Read();
        }
    }
}
