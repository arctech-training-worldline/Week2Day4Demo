using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Demo.OperatorOverloading
{
    class Student
    {
        public int rollNo;
        public string Name;

        public static bool operator==(Student s1, Student s2)
        {
            if(s1.rollNo == s2.rollNo && s1.Name == s2.Name)
                return true;

            return false;
        }

        public static bool operator !=(Student s1, Student s2)
        {
            if (s1.rollNo == s2.rollNo && s1.Name == s2.Name)
                return false;

            return true;
        }
    }

    internal class EqualityDemo
    {        
        internal static void Test()
        {
            string s1 = "Hello";
            string s2 = "World";

            bool check1 = s1 == s2;         // equality check
            bool check2 = s1.Equals(s2);    // Identity check
            
            Console.WriteLine($"check1 = {check1} check2 = {check2}");
        }

        internal static void Test2()
        {
            Student s1 = new Student { rollNo = 101, Name = "Rajesh" };
            Student s2 = new Student { rollNo = 101, Name = "Rajesh" };
            Student s3 = s2;

            bool check1, check2, check3;

            check1 = s1 == s2;
            check2 = s1 == s3;
            check3 = s2 == s3;

            Console.WriteLine($"1. check1={check1}, check2={check2}, check3={check3}");


            check1 = s1.Equals(s2);
            check2 = s1.Equals(s3);
            check3 = s2.Equals(s3);

            Console.WriteLine($"2. check1={check1}, check2={check2}, check3={check3}");

        }
    }
}
