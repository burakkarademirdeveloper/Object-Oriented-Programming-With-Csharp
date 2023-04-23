using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int heigth, int width)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = heigth;
        }

        public override string ToString()
        {
            return $"X:{X} Y: {Y} Heigth: {Height} Width: {Width}";
        }

        public override void Draw()
        {
            Console.WriteLine("Circle:   X:{0}     Y:{1}     Heigth:{2}     Width:{3}", X, Y, Height, Width);
        }
    }
}
