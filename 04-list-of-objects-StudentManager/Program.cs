using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_list_of_objects_StudentManager
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

                Console.Write("Student Name (string): ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Student Grade (int): ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.Write("Student Birthday (yyyy-mm-dd): ");
                newStudent.Birthday = Console.ReadLine();

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() == "n")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Birthday: {student.Birthday}");
            }
        }
    }

    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
    }
}
