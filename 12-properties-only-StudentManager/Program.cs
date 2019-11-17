using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_properties_only_StudentManager
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
                newStudent.name = Console.ReadLine();

                Console.Write("Student grade (int): ");
                newStudent.grade = int.Parse(Console.ReadLine());

                students.Add(newStudent);

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
        private string _name;  // a private field
        private int _grade; // a private field
        public string name
        {
            get { Console.WriteLine("Inside name getter"); return _name; }
            set { Console.WriteLine("Inside name setter"); _name = value; }
        }
        public int grade
        {
            get { Console.WriteLine("Inside grade getter"); return _grade; }
            set { Console.WriteLine("Inside grade setter"); _grade = value; }
        }


    }
}
