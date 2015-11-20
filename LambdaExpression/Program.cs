using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    delegate void CountIt();
    delegate int MyDel(int x);
    delegate int MyDel2(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            

            CountIt count = () => Console.WriteLine("I am in Lambda Expression");

            count();

            MyDel d1 = (int x) => x + x;

            int y = d1(4);
            Console.WriteLine("y = " + y);

            d1 = z => z * z;

            int k = d1(3);

            Console.WriteLine(" k = " + k);

            MyDel2 d2 = (x, h) =>
              {
                  Console.WriteLine("x = " + x + " h= " + h);
                  return x + h;
              };

            int g= d2(1, 2);
            Console.WriteLine("g =" + g);
        }
    }
}
