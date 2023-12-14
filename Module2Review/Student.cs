using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review;
internal class Student
{
    public Student()
    {
        
    }
    public Student(int id, string name)
    {
        ID = id;
        Name = name;
    }
    public int ID { get; set; }
    public string Name { get; set; }
    public List<double> Grades { get; set; } = new List<double>();

    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }
    public void AddGrade(params double[] grades) 
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }
        return Grades.Average();

    }
}
