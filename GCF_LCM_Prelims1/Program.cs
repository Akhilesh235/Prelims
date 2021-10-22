using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCF_LCM_Prelims1
{
    /// <summary>
    /// Prelims Qn1
    /// Given two numbers, find the GFC(Greatest Common Factor) and 
    /// LCM (Lowest Common Multiple) of the two numbers.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input First Number :");
            int FN = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Second Number :");
            int SN = int.Parse(Console.ReadLine());

            Program p = new Program();
            
            Console.WriteLine("The GCF of {0} and {1} are: {2} ", FN,SN, p.GCF(FN,SN));
            Console.WriteLine("The LCM of {0} and {1} is: {2} ", FN, SN, p.LCM(FN,SN));
            Console.ReadLine();

        }

        public int GCF(int a, int b)
        {
            int x;
            while (b !=0)
            {
                x = a % b;
                a = b;
                b = x;
            }
            return a;
        }

        public int LCM(int a, int b)
        {
            int i;
            int j;

            if (a > b)
            {
                i = a;
                j = b;
            }
            else
            {
                i = b;
                j = a;
            }
            for (int x = 1; x <= j; x++)
            {
                if ((i * x) % j == 0)
                {
                    return i * x;
                }
            }
            return j;
        }
    }
}
