using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_fields_vs_properties_encapsulation_StudentManager
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

                Console.Write("Student gradeField directly (int): ");
                newStudent.gradeField = int.Parse(Console.ReadLine());

                Console.Write("Student gradeField1 with method (int): ");
                newStudent.setGrade1(int.Parse(Console.ReadLine()));

                Console.Write("Student gradeProperty (int): ");
                newStudent.gradeProperty = int.Parse(Console.ReadLine());

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() == "n")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, gradeField1: {student.gradeField}, gradeField2: {student.getGrade1()}, gradeProperty: {student.gradeProperty}");
            }
        }
    }

    class Student
    {
        public string name;  // a public field
        public int gradeField; //a public field
        private int _gradeField1; // a public field
        private int _gradeField2; // a private field
        public int getGrade1()
        {
            Console.WriteLine("Inside getGrade1");
            return _gradeField1;
        }
        public void setGrade1(int number)
        {
            Console.WriteLine("Inside setGrade1");
            _gradeField1 = number;
        }
        public int gradeProperty
        {
            get { Console.WriteLine("Inside gradeProperty getter"); return _gradeField2; }
            set { Console.WriteLine("Inside gradeProperty setter"); _gradeField2 = value; }
        }


    }
}
