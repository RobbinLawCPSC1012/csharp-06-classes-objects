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

                newStudent.name = getString("Student Name (string): ");   
                newStudent.gradeField = getInt("Student grade (int): ");      
                newStudent.setGrade1(getInt("Student gradeField1 with method (int): ")); 
                newStudent.gradeProperty = getInt("Student gradeProperty (int): ");
                students.Add(newStudent);
                char addNewStudent = getChar("Add another? y/n: ");
                if (addNewStudent == 'n')
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, gradeField1: {student.gradeField}, gradeField2: {student.getGrade1()}, gradeProperty: {student.gradeProperty}");
            }
        }

        static string getString(string msg)
        {
            try
            {
                Console.Write(msg);
                string str = Console.ReadLine();
                return str;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return getString(msg);
            }

        }

        static int getInt(string msg)
        {
            try
            {
                Console.Write(msg);
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                    throw new Exception("Invalid Input: Must be positive number");
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return getInt(msg);
            }

        }

        static char getChar(string msg)
        {
            try
            {
                Console.Write(msg);
                char myChar = char.Parse(Console.ReadLine());
                if (myChar != 'y' && myChar != 'n')
                    throw new Exception("Invalid Input: Must be y or n");
                return myChar;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return getChar(msg);
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
