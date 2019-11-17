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

                newStudent.name = getString("Student Name (string): ");   
                newStudent.grade = getInt("Student grade (int): ");
                students.Add(newStudent);
                char addNewStudent = getChar("Add another? y/n: ");
                if (addNewStudent == 'n')
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, grade: {student.grade}");
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
