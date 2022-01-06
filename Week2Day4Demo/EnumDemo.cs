using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Demo
{
    internal class EnumDemo
    {
        enum CompassDirection
        { 
            Unknown,
            North,
            East,
            West,
            South,
            NorthEast,
            NorthWest,
            SouthEast,
            SouthWest
        }

        class Compass
        {
            public ConsoleColor color;
            public int diameter;
            public bool isGoldPlated;
            public CompassDirection currentDirection;

            public override string ToString()
            {
                return $"color={color},diameter={diameter}, isGoldPlated={isGoldPlated}, currentDirection={currentDirection}";
            }
        }

        internal static void Test()
        {
            Compass compass1 = new Compass
            {
                color = ConsoleColor.Green,
                diameter = 10,
                isGoldPlated = true,
                currentDirection = CompassDirection.North
            };

            Compass compass2 = new Compass
            {
                color = ConsoleColor.Red,
                diameter = 20,
                isGoldPlated = true,
                currentDirection = CompassDirection.SouthWest
            };

            Console.WriteLine($"Compass1 => {compass1}");
            Console.WriteLine($"Compass2 => {compass2}");

            Console.WriteLine($"Compass1.Direction= {compass1.currentDirection}");
            Console.WriteLine($"Compass1.Direction= {compass2.currentDirection}");
        }

        internal static void TestEnumWithConsoleInput()
        {
            Compass compass = new Compass();
            
            string directionText;
            // Enum data entry type 1
            // Problem: User has to remember the number
            Console.Write("Type1: Enter Direction:");
            directionText = Console.ReadLine();
            compass.currentDirection = (CompassDirection)int.Parse(directionText);
            Console.WriteLine($"Input Type1 - compass => {compass}");
            Console.WriteLine("------------------------------------");


            // Enum data entry type 2
            // Problem: User can type 'X', which you have to validate and show error message
            // This is the preferred way in console applications
            // However in windows applications, you will have ask user to select from a dropdown
            Console.WriteLine("Type2: Enter Direction (s)outh, (n)orth:");
            directionText = Console.ReadLine();
            switch(directionText)
            {
                case "s":
                case "S":
                    compass.currentDirection = CompassDirection.South;
                    break;
                case "n":
                case "N":
                    compass.currentDirection = CompassDirection.North;
                    break;
                // etc...
            }
            Console.WriteLine($"Input Type2 - compass => {compass}");
            Console.WriteLine("------------------------------------");

            // Enum data entry type 3
            // Problem: User can type 'anytext', which you have to validate
            //          Also user has to remember the spelling of the direction
            //          causing large number of input errors
            Console.WriteLine("Type3: Enter Direction in full text. e.g. North: ");
            directionText = Console.ReadLine();
            Type type = typeof(CompassDirection);
            compass.currentDirection = (CompassDirection)Enum.Parse(type, directionText, true);

            Console.WriteLine($"Input Type3 - compass => {compass}");
            Console.WriteLine("------------------------------------");
        }
    }
}
