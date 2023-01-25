using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConParams
{
    internal class Split
    {
        static void Main()
        {
            String str = "Today is Friday and this is the last day of the week";
            String[] arr = str.Split( ' ', 'T', 'e');
            foreach (String s in arr)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
