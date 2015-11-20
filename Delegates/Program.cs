using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int MathOperation(int x, int y);
    delegate void MyDelegate();

    class Program
    {
        static int Add(int x, int y)
        {
            Console.WriteLine("Add Function and sum =" + (x + y));
            return x + y;
        }

        static void Main(string[] args)
        {
            //calling add
           // Add(2,1);

            MathOperation op = new MathOperation(Add);

            MyClass obj = new MyClass();
            MyDelegate d1 = obj.M1;

            d1();
            
           
            //op(3, 5);
        }
    }
}
