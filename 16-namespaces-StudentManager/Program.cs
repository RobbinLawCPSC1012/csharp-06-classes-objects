using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_namespaces_StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.WriteLine("Student Name (string): ");
                newStudent.name = Console.ReadLine();

                Console.Write("Student grade (int): ");
                newStudent.grade = int.Parse(Console.ReadLine());

                students.Add(newStudent);
                Student.count++;
                Console.WriteLine($"The static Student.count is: {Student.count}");

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() == "n")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, grade: {student.grade}");
            }
        }
    }

    class Student
    {
        static public int count = 0;
        public string name;
        public int grade;
    }
}
