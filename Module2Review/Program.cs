namespace Module2Review;

internal class Program
{
    static void Main(string[] args)
    {
        //dot notation
        Student student1 = new Student();
        student1.ID = 1;
        student1.Name = "John Smith";
        

        //object initializer syntax
        Student student2 = new Student() { ID = 2, Name = "Lisa Jones"};
    

        //custom constructor
        Student student3 = new Student(3, "Jacob James");
        Student student4 = new Student(4, "Bob Ashley");

       
        //adding grades to student 1 
        student1.AddGrade(96.4);
        student1.AddGrade(78.4, 90.0, 87.3);

        //adding grades to student 2
        student2.AddGrade(87.9, 90.4, 97.2);
        student2.AddGrade(91.3);

        //adding grades to student 3
        student3.AddGrade(83.4, 88.7);
        student3.AddGrade(70.5);

        //adding grades to student 4
        student4.AddGrade(55.9, 72.5);
        student4.AddGrade(77.8);

        //create a list and populate it
        List<Student> students = new List<Student>() { student1, student2, student4, student4 };


        //iterate through list with a loop
        foreach (var item in students)
        {
            Console.WriteLine($"Student ID: {item.ID}");
            Console.WriteLine($"Student Name: {item.Name}");
            //Nested loop to view student grades
            foreach (var grade in item.Grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine($"{item.Name}'s Average Grade: {item.CalculateAverageGrade()}");
            Console.WriteLine();
            Console.WriteLine();
        }

        //create a Course
        Course course1 = new Course();

        course1.CourseName = "Coding 101";
        course1.CourseCode = "1456Computer";

        //add student 1 and 2 to the course
        course1.EnrollStudent(student1);
        course1.EnrollStudent(student2);

        //try adding student 1 to the course again
        course1.EnrollStudent(student1);

        //display course details and the students that are enrolled in the course
        Console.WriteLine($"Course Name:  {course1.CourseName}");
        Console.WriteLine($"Course Code: {course1.CourseCode}");

        Console.WriteLine("Students enrolled in the course: ");
        foreach (var item in course1.EnrolledStudents)
        {
            Console.WriteLine(item.Name);
        }





    }
}
