using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Demo
{
    //User Defined Type - class, struct
    // class - Reference Type
    // struct - Value Type
    struct Student
    {
        public int id;
        public string name;
        public int age;

        public override string ToString()
        {
            return $"id={id}, name={name}, age={age}";
        }
    }    

    class Teacher
    {
        public int id;
        public string name;
        public int age;

        public string GetAllDataForDisplay()
        {
            return $"id={id}, name={name}, age={age}";
        }

        public override string ToString()
        {
            return $"id={id}, name={name}, age={age}";
        }
    }

    internal class StructDemo
    {
        internal static void TestStruct()
        {
            Student student = new Student { id = 1, name = "Raman Gujral", age = 10 };
            Teacher teacher = new Teacher { id = 101, name = "Ramen Noodles", age = 45 };

            Student student2 = student;
            Teacher teacher2 = teacher;

            //Not needed after we overrode ToString method
            //Console.WriteLine($"id={student.id}, name={student.name}, age={student.age}");


            //Console.WriteLine(student.ToString());
            //Console.WriteLine(student2.ToString());
            //Console.WriteLine(teacher.ToString());
            //Console.WriteLine(teacher2.ToString());
            
            // Explicit ToString is not needed when using string interpolation
            // Since string interpolation create a string using different variables
            // it converts each variable to a string. It does this by automatically 
            // calling ToString() if available.
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Student = {student}");
            Console.WriteLine($"Student2 = {student2}");
            Console.WriteLine($"Teacher = {teacher}");
            Console.WriteLine($"Teacher2 = {teacher2}");
            Console.WriteLine("---------------------------");

            student2.name = "Maggie Noodles";
            teacher2.name = "Ramen Curry";

            Console.WriteLine($"Student = {student}");
            Console.WriteLine($"Student2 = {student2}");
            Console.WriteLine($"Teacher = {teacher}");
            Console.WriteLine($"Teacher2 = {teacher2}");            
            Console.WriteLine("---------------------------");
        }
    }
}
