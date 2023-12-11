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

       
        //adding grades
        student1.AddGrade(96.4);
        student1.AddGrade(78.4, 90.0, 87.3);
        student2.AddGrade(87.9, 90.4, 97.2);
        student2.AddGrade(91.3);
        student3.AddGrade(83.4, 88.7);
        student3.AddGrade(70.5);
        student4.AddGrade(55.9, 72.5);
        student4.AddGrade(77.8);


        GradeManager gradeManager = new GradeManager();

        


    }
}
