using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Demo.OperatorOverloading
{
    public class Point
    {
        public int X;
        public int Y;
    }

    public class Size
    {
        public int Width;
        public int Height;

        //internal void Grow()
        public static Size operator++(Size size)
        {
            size.Width++;
            size.Height++;

            return size;
        }

        // internal void Shrink()
        public static Size operator--(Size size)
        {
            size.Width--;
            size.Height--;

            return size;
        }
    }

    public class Rectangle
    {
        public Point point;
        public Size size;

        public Rectangle(int x, int y, int width, int height)
        {
            point = new Point { X = x, Y = y };
            size = new Size { Width = width, Height = height };
        }

        //public bool Intersects(Rectangle r)
        public static bool operator ^(Rectangle r1, Rectangle r2)
        {
            return r1.point.X >=  r2.point.X && 
                r1.point.X <= r2.point.X + r2.size.Width &&
                r1.point.Y >= r2.point.Y && 
                r1.point.Y <= r2.point.Y + r2.size.Height;            
        }

        public void Draw()
        {
            string innerSpaces = new string(' ', size.Width - 2);
            string headerFooter = new string('=', size.Width);

            Console.SetCursorPosition(point.X, point.Y);
            Console.Write($"{headerFooter}");

            for (int row = 1; row < size.Height - 1; row++)
            {
                Console.SetCursorPosition(point.X, point.Y + row);
                Console.Write($"|{innerSpaces}|");
            }

            Console.SetCursorPosition(point.X, point.Y + size.Height - 1);
            Console.Write($"{headerFooter}");

            Console.WriteLine();
        }

        public void Clear()
        {
            Console.Clear();
        }
    }


    internal class OperatorOverloadingRealLifeExample
    {
        public static void Test()
        {
            Rectangle r = new Rectangle(5, 5, 15, 5);
            r.Draw();

            Rectangle r2 = new Rectangle(10, 7, 25, 7);
            r2.Draw();

            //if(r.Intersects(r2))
            if(r ^ r2)
                Console.WriteLine("Both rectanges are intersecting");
            else
                Console.WriteLine("Both rectanges are NOT intersecting");

            ConsoleKey key = ConsoleKey.Escape;
            
            do
            {
                var keyInfo = Console.ReadKey(true);

                key = keyInfo.Key;

                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        //r.size.Grow();
                        r.size++;
                        r.Clear();
                        r.Draw();
                        break;
                    case ConsoleKey.LeftArrow:
                        //r.size.Shrink();
                        r.size--;
                        r.Clear();
                        r.Draw();
                        break;
                    default:
                        break;
                }

            } while (key != ConsoleKey.Escape);
        }
    }
}
