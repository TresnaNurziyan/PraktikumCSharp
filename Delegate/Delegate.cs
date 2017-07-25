using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate double Delegate_Prod(int a, int b);
    class Delegate
    {
        static double fn_Prodvalues(int val1, int val2)
        {
            return val1 * val2;
        }
        static void Main(String[] args)
        {
            Delegate_Prod delObj = new Delegate_Prod(fn_Prodvalues);

            Console.Write("Please Enter Value : ");
            int v1;
            int v2;
           v1 = int.Parse(Console.ReadLine());
           v2  = int.Parse(Console.ReadLine());

            double res = delObj(v1, v2);
            Console.WriteLine("Result : " + res);
            Console.ReadLine();    
        }
    }
}
