using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            //[] arr = { 1, 2, 3, 4, 5, 6 }; 
            //list.AddRange(arr); 
            list.AddRange(new int[] { 3, 5, 7, 8, 9 });
            Console.WriteLine("data in list after using AddRange Method");
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            var res = list.GetEnumerator();
            while (res.MoveNext())
            {
                Console.WriteLine(res.Current + " ");
            }

            var res2 = list.Append(45);

            Console.WriteLine("After using the method Append");
            foreach (var item in res2)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After Using Aggregate....");
            Console.WriteLine($" {list.Aggregate((a, b) => a * b)}");
            Console.WriteLine();
            Console.Read();
        }

        }
    }

