using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Demo
{
    class X
    {
        int age;
        int year;

        // nested class
        internal class Y
        {
            string name;
        }
    }
    
    class Home
    {
        int floor;
        int squarefeet;
        int rooms;
        HomeSize livingRoomSize = new HomeSize { length = 100, breadth = 200 };
        HomeSize bedRoomSize = new HomeSize { length = 200, breadth = 300 };
        
        // nested struct
        // Used when you need to create a class/struct which is useful
        // only to the current parent class. So we can create a private nested class/struct
        private struct HomeSize
        {
            public int length;
            public int breadth;
        }
    }

    internal class TestNestedTypes
    {
        internal static void Test()
        {
            X x = new X();
            X.Y y = new X.Y();            
        }
    }
}
