using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e;
            double n1;
            double R;
            //aresta
            Console.WriteLine("valor da aresta");
            n1 = double.Parse(Console.ReadLine());
            // e é igual a n1
            e = n1;
            //R é igual a e multiplicado po e
            R = n1 * e;

            //resultado

            Console.WriteLine("valor da aresta {0}", R);
        }
    }
}
