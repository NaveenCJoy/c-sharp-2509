using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Student
    {
        public string name;
        public int id;
        public List<double> grades = new List<double>();

        public Student(string Name, int Id)
        {
            name = Name;
            id = Id;
        }

        public void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException("Enter grade between 0 and 100");
            }
        }

        public double CalculateGradesAverage()
        {
            return grades.Average();
        }
        
    }

    public class StudentsList
    {
        public List<Student> studentslist = new List<Student>();

        //add student
        public void AddStudent(Student student)
        {
            studentslist.Add(student);
        }

        //remove student
        public void RemoveStudent(Student student)
        {
            studentslist.Remove(student);
        }

        //display all student names
        public void DisplayStudents()
        {
            foreach (Student student in studentslist)
            {
                Console.WriteLine("ID : " + student.id + " Name : " + student.name);
            }
            
        }
    }

   
}
