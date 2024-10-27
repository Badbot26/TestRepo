using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.LiskovSubstitution
{
    public static class Engine
    {
        public class Rectangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public Rectangle() { }

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public override string ToString()
            {
                return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
            }
        }

        public class Square : Rectangle
        {
            public override int Width
            {
                set { base.Width = base.Height = value; }
            }
            public override int Height
            {
                set { base.Height = base.Width = value; }
            }
        }

        public static int Area(Rectangle r) => r.Width * r.Height;

        public static void Run()
        {
            // should be able to substitute a base type for a subtype
            // use virtual and override keywords to help enforce the Liskov substitution principle

            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");
        }
    }
}
