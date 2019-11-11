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
                newStudent.name = Console.ReadLine();

                Console.Write("Student gradeField1 directly (int): ");
                newStudent.gradeField1 = int.Parse(Console.ReadLine());

                Console.Write("Student gradeField2 with method (int): ");
                newStudent.setGrade2(int.Parse(Console.ReadLine()));

                Console.Write("Student gradeProperty (int): ");
                newStudent.gradeProperty = int.Parse(Console.ReadLine());

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() == "n")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, gradeField1: {student.gradeField1}, gradeField2: {student.gradeField2}, gradeProperty: {student.gradeProperty}");
            }
        }
    }

    class Student
    {
        public string name;  // a public field
        public int gradeField1; //a public field
        public int gradeField2; // a public field
        private int _gradeField; // a private field

        public void setGrade2(int number)
        {
            gradeField2 = number;
        }

        public int gradeProperty
        {
            get { Console.WriteLine("Inside getter"); return _gradeField; }
            set { Console.WriteLine("Inside setter"); _gradeField = value; }
        }

        
    }
}
