using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static ConParams.Class;

namespace ConParams
{
    class details
    {
        public static void AddPersonalDetails(string name,
              string firstName, string lastName, string petName)
        {
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"firstname : {firstName}");
            Console.WriteLine($"lastname : {lastName}");
            Console.WriteLine($"petname : {petName}");
        }
    }
    internal class Class
    {
        

        static void Main()
        {
           
            details.AddPersonalDetails(name: "RutujaSankhe",
                                               firstName: "Rutuja",
                                                lastName: "Sankhe",
                                                 petName: "Rutuja");
            Console.WriteLine();
        }
    }
}