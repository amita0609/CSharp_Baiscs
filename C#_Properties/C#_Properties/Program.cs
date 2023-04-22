using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "Sonoo Jaiswal";
            Console.WriteLine("Employee Name: " + e1.Name);

            Console.ReadLine();
        }
    }
}
