using System;
using System.Collections.Generic;
using System.Text;

// Course must have the following properties
// a string for the course title
// a Teacher for the teacher assigned to the course
// a Student array for the students in the course

namespace JeanLaurore_CE04
{

    public class Course
    {
        public string CourseTitle { get; set; }
        public Student[] Class { get; set; }
        public Teacher teacher { get; set; }


        public Course(string courseTitle, int student)
        {
            CourseTitle = courseTitle;
            Class = new Student[student];

            Console.WriteLine("Course Created!");
        }
    }
}
