using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Demo
{
    internal class ArrayDemo
    {
        public static void TestJaggedArray()
        {
            int[][] jaggedArray1 = new int[2][];

            jaggedArray1[0] = new[] { 10, 20, 30, 40 };
            jaggedArray1[1] = new int[] { 1, 2 };

            foreach (int[] item in jaggedArray1)
            {
                Console.WriteLine("How many times as I looping");

                foreach (int num in item)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static void Test4()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
        }

        public static void Test3()
        {
            int[] ages = { 22, 32, 55, 4, 7 };

            Console.WriteLine("---------------------");
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
            Console.WriteLine("---------------------");
            Array.ForEach(ages, age => Console.WriteLine(age));
            Console.WriteLine("---------------------");
        }

        public static void Test1()
        {
            int[] ages = { 10, 20, 30 };
            int[] num = new int[10];
            int[] num2 = new int[] { 10, 20, 30 };
            Array.Sort(num);

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            string[] cars2;
            cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            Console.WriteLine(Array.BinarySearch(ages, 31));// binary search 
        }

        public static void Test2()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };

            nums = new[] { 1, 2, 3 };
        }
    }
}
