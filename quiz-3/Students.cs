using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public List<Lecture> Lectures { get; set; } =new List<Lecture>();
}
public class Lecture
{
    public int LectureId { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public int Capacity { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
}
