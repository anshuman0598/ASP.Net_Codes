using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Shape
    {
       // public void Display() { Console.WriteLine("Shape - Display"); }
        public virtual string Draw() { return ("Shape - Draw"); }
    }
    class Square : Shape
    {
        //public new void Display() { Console.WriteLine("Square - Display"); }
        public new string Draw() {return ("Square - Draw"); }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Shape s = new Square();
            var result = s.Draw();
            Console.WriteLine(result);
            s = new Shape();
            result = s.Draw();
            System.Console.WriteLine(result);


            s.Draw();
        }
    }
}
