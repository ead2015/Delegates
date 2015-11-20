using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    delegate void CountIt();
    delegate void CountIt2(int i);
    delegate int CountIt3(int i);


    class Program
    {
        static void Main(string[] args)
        {

            CountIt count = delegate
            {
                Console.WriteLine("I am in anonymous method");
            };

           
            count();

            ////////////////////////////////////////////////////////////////

            CountIt2 count2 = delegate(int p1)
            {
                Console.WriteLine("I am in anonymous method with parameter = " + p1);
               
            };

            
            count2(2);

            CountIt3 count3 = delegate(int x) {
                Console.WriteLine("I am in anonymous method with parameter = " + x);
                return x + x;
            };

           
            int y = count3(2);
            Console.WriteLine("Y = " + y);
        }
    }
}
