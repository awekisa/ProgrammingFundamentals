using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double Avg { get; set; }

}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();
        for (int i = 0; i < n; i++)
        {
            string[] arr = Console.ReadLine().Split();
            String name = arr[0];
            List<double> grades = new List<double>();
            for (int j = 1; j < arr.Length; j++)
            {
                grades.Add(double.Parse(arr[j]));
            }
            double avg = grades.Average();
            Student student = new Student() { Name = name, Grades = grades, Avg = avg };
            students.Add(student);
        }
        List<Student> bestStudents = new List<Student>();
        bestStudents = students.Where(s => s.Avg >= 5).OrderByDescending(s => s.Avg).OrderBy(s => s.Name).ToList();
        foreach (var s in bestStudents)
        {
            Console.WriteLine("{0} -> {1:f2}", s.Name, s.Avg);
        }
    }
}

