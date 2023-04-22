using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C__Struct.Rectangle;

namespace C__Struct
{
    public struct Rectangle
    {
        public int width, height;

        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public void areaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 6);
            r.areaOfRectangle();



            //There are amny ways to access enum

            int x = (int)Days.Sun;
            int y = (int)Days.Mon;
            int z = (int)Days.Sat;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Mon = {0}", y);
            Console.WriteLine("Sat = {0}", z);


            foreach (Days d in Enum.GetValues(typeof(Days)))  //getValues() also method to get values.
            {
                Console.WriteLine(d);
            }


            Console.ReadLine();
        }
    }
}
