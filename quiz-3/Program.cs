class Program
{
    static void Main()
    {
        using var context = new ApplicationContext();

        var student = new Student { Name = "John Doe", EnrollmentDate = DateTime.Now };

        var lecture = new Lecture
        {
            Title = "Introduction to Entity Framework",
            Date = DateTime.Now.AddDays(7),
            Capacity = 50
        };
        context.Add(student);
        context.Add(lecture);
        context.SaveChanges();
       var sst = context.Students.First();
        Console.WriteLine(sst.Name);

    }
}
