using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelims
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = new Derived();
            Console.ReadLine();
            

        }
    }

    public class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived called");
        }
    }

    public class Base
    {
        public Base()
        {
            Console.WriteLine("Base called");
        }
    }
}
