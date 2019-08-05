using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Rectangle
    {
        int height = 0;
        int width = 0;
        int area = 0;
        int perimeter = 0;

        internal int getArea()
        {
            return height * width;
        }

        internal int getPerim()
        {
            return (height * 2) + (width * 2);
        }

        private int getSide(string v)
        {
            Console.Write(v);
            return int.Parse(Console.ReadLine());
        }
        public Rectangle()
        {
            Console.WriteLine("\nCreating a Rectangle:");
            this.height = getSide("Enter the height: ");
            this.width = getSide("Enter the width: ");

        }
        
        public override string ToString()
        {
            return ($"Rectangle: Height = {this.height}, Width = {this.width}"); //returns a string representation of my triangle, $=an interpolated string
        }
        
    }
}
