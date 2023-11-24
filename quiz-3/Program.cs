class Program
{
    static void Main()
    {
        using var context = new ApplicationContext();

        var student1 = new Student { Name = "John Doe", EnrollmentDate = DateTime.Now };
        var student2 = new Student { Name = "Jane Doe", EnrollmentDate = DateTime.Now };

        var lecture = new Lecture
        {
            Title = "Introduction to Entity Framework",
            Date = DateTime.Now.AddDays(7),
            Capacity = 50
        };

    }
}
