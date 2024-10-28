using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class University
    {
        public List<Department> departmentsList = new List<Department>();

        public void AddDepartment(string name)
        {
            departmentsList.Add(new Department(name));
        }

        public void AddCourse(string departmentName, string CourseName, int CourseCode, int Credits)
        {
            Department result = departmentsList.Find(d => d.departmentName == departmentName);
            if (result != null)
            {
                result.AddCourseToList(CourseName, CourseCode, Credits);
                Console.WriteLine($"Course: {CourseName} added to department: {departmentName}");
                Console.WriteLine();
            }
        }

        public void DisplayAllDetails()
        {
            Console.WriteLine("Department and Course Details:");
            foreach(Department dep in departmentsList)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"Department: {dep.departmentName}");
                dep.DisplayCourseDetails();
            }
        }


        public class Department
        {
            public string departmentName;
            public List<Course> courseList = new List<Course>();

            public Department(string name)
            {
                departmentName = name;
            }

            public void AddCourseToList(string CourseName, int CourseCode, int Credits)
            {
                courseList.Add(new Course(CourseName, CourseCode, Credits));                
            }

            public void DisplayCourseDetails()
            {
                foreach(Course course in courseList)
                {
                    Console.WriteLine($"Course: {course.courseName}  Code: {course.courseCode}" +
                        $"  Credits: {course.credits}")
                }
            }


            public class Course
            {
                public string courseName;
                public int courseCode;
                public int credits;

                public Course(string CourseName, int CourseCode, int Credits)
                {
                    courseName = CourseName;
                    courseCode = CourseCode;
                    credits = Credits;
                }
            }
        }
    }
}
