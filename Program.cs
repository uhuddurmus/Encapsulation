using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Mustafa Uhud";
            student.Surname = "Durmus";
            student.StudentNo = 181;
            student.Class = 4;
            student.GetStudentInfo();
            student.ClassDown();
            student.GetStudentInfo();

            Student student2 = new Student("Haydar", "Haydaroğlu", 111, 1);
            student2.ClassDown();
            student2.ClassDown();
            student2.GetStudentInfo();
        }
    }
    class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int grade;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int Class
        {
            get => grade;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Class must bigger than one");
                    grade = 1;
                }
                else { grade = value; }
            }
        }

        public Student(string name, string surname, int studentNo, int grade)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            Class = grade;
        }
        public Student() { }
        public void GetStudentInfo()
        {
            Console.WriteLine("-----------Info----------");
            Console.WriteLine("Name:" + this.Name);
            Console.WriteLine("Surname:" + this.Surname);
            Console.WriteLine("No:" + this.StudentNo);
            Console.WriteLine("Class:  " + this.Class);
        }
        public void ClassUp()
        {
            this.Class = this.Class + 1;
        }
        public void ClassDown()
        {
            this.Class = this.Class - 1;
        }
    }

}
