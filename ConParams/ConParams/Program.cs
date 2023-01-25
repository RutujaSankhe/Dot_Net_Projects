using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConParams
{
    internal class Program
    {
        
        public static int Add(params int[] ListNumber)
        {
            int sum = 0;
            foreach (int i in ListNumber)
            {
                sum += i;
            }
            return sum;
        }
        public static int Mul(params int[] ListNumber)
        {
            int total = 1;
            foreach (int j in ListNumber)
            {
                total *= j;
            }
            return total;
        }
        static void Main(string[] args)
        {
            int y = Add(5, 4, 2, 1, 3);
            int x = Mul(2, 1, 4, 3, 5);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
