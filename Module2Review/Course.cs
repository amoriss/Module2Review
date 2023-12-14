using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review;
internal class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }

    public List<Student> EnrolledStudents;
    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    //method to enroll student
    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Exists(s => s.ID == student.ID))
        {
            Console.WriteLine($"{student.Name} is successfully added to {CourseName}.");
            EnrolledStudents.Add(student);
        }
        else 
        {
            Console.WriteLine($"{student.Name} is already enrolled in {CourseName}.");
        }
        
    }
}
