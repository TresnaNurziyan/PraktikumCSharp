using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    class Tester
    {
        public void DisplayVals(params int[] intVal)
        {
            foreach(int i in intVal)
            {
                Console.WriteLine("DisplayVals {0}", i);
            }
        }

        static void Main()
        {
            Tester t = new Tester();
            t.DisplayVals(5, 6, 7, 8);
            int[] explicitArray = new int[5] { 1, 2, 3, 4, 5 };
            t.DisplayVals(explicitArray);

            Console.Read();
        }
    }
}
