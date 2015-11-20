using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    delegate void MyDelegate(int x);

    class Program
    {
        static void M1(int y)
        {
            Console.WriteLine("M1 = "+ y);
        }
        static void M2(int y)
        {
            Console.WriteLine("M2 = "+y);
        }

        static void M3(int y)
        {
            Console.WriteLine("M3 = "+ y);
        }

        static void Main(string[] args)
        {
            MyDelegate del = M1;
            del(3);

            del += M2;
           // del -= M2;
           
            del(4);

            del += M3;

            del(5);

        }
    }
}
