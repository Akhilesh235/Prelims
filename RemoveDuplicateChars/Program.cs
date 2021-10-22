using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateChars
{
    /// <summary>
    /// Prelims Qn3
    /// Write a program which removes all the duplicate characters 
    /// from each word of a given string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = "Bookkeeper".ToCharArray();
            int x = str.Length;
            Program p = new Program();
            Console.WriteLine(p.removechar(str, x));
            Console.ReadLine();
        }

        public string removechar(char []str, int x)
        {
            int a = 0;
            for (int i = 0; i < x; i++)
            {
                int j;
                for (j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        break;
                    }
                }

                if (j == i)
                {
                    str[a++] = str[i];
                }
            }
            char[] finaloutput = new char[a];
            Array.Copy(str, finaloutput, a);
            return String.Join("", finaloutput);
        }
    }
}
