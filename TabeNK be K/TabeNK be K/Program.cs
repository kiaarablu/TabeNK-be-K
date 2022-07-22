using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabeNK_be_K
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(combination(8, 5));
            Console.ReadKey();
        }
        public static int combination(int n, int k)
        {
            if (k == 0 || n == k)
            {
                return 1;
            }
            else
            {
                return (combination(n-1 , k-1) + combination(n-1 , k));
            }

        }
        
    }
    
}
