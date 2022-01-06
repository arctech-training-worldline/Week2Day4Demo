using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Demo.OperatorOverloading
{
    // Create a box class to display a box on the screen
    // This box should have dimensions as specified in the constructor
    // Allow the box to grow or shrink, 1 size at a time, where size can be row & columns
    class Box
    {
        int x, y;
        int width, height;

        public Box(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public static Box operator ++(Box b)
        {
            b.width++;
            b.height++;

            return b;
        }

        //public void Grow()
        //{
        //    width++;
        //    height++;
        //}

        public static Box operator --(Box b)
        {
            if (b.width > 3)
                b.width--;

            if (b.height > 3)
                b.height--;

            return b;
        }

        //public void Shrink()
        //{
        //    if(width > 3)
        //        width--;

        //    if(height > 3)
        //        height--;
        //}

        // Union implemention
        //public static Box DoUnion(Box b1, Box b2)
        public static Box operator+(Box b1, Box b2)
        {
            int x = (b1.x + b2.x) / 2;
            int y = (b1.y + b2.y) / 2;
            int width = b1.width + b2.width;
            int height = b1.height + b2.height;

            Box b3 = new Box(x, y, width, height);

            return b3;
        }

        public static Box operator +(Box b1, int num)
        {            
            int width = b1.width + num;
            int height = b1.height + num;

            Box b3 = new Box(b1.x, b1.y, width, height);

            return b3;
        }

        public static int operator -(Box b1, int num)
        {
            int width = b1.width + num;
            int height = b1.height + num;

            Box b3 = new Box(b1.x, b1.y, width, height);

            return b3.width;
        }

        public override string ToString()
        {
            return $"x={x}, y={y}, width={width}, height={height}";
        }
    }

    internal class OperatorOverloadingDemo1
    {
        internal static void Test()
        {
            Box box1 = new Box(5, 5, 10, 5);
            Console.WriteLine($"box1={box1}");

            //box1.Grow();
            Box b01 = box1++;
            Box b02 = ++box1;

            Console.WriteLine($"box1={box1}");

            //box1.Shrink();
            //box1.Shrink();
            box1--;
            box1--;
            Console.WriteLine($"box1={box1}");

            Box box2 = new Box(10, 10, 20, 20);
            Console.WriteLine($"box2={box2}");

            //Box box3 = Box.DoUnion(box1, box2);
            Box box3 = box1 + box2;
            Console.WriteLine($"box3={box3}");

            Box box4 = box1 + 10;
            Console.WriteLine($"box4={box4}");
        }
    }
}
