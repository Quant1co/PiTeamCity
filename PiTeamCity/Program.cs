using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIteamcity
{
    public class Program
    {
        static void Main()
        {
            CheckFermatTheorem(1);....
        }
        public static void CheckFermatTheorem(int n)
        {
            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 1; c < n; c++)
                    {
                        if (Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n))
                        {
                            Console.WriteLine("Fermat's theorem is wrong!");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Fermat's theorem holds for all numbers up to " + n);
        }
    }
}

//измение в коде
