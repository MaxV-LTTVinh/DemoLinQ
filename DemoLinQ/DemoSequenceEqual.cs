namespace DemoLinQ;

public static class DemoSequenceEqual
{
    public static void Run()
    {
        var students = new List<Student>
        {
            new() { Id = 1, Name = "John", Age = 13 },
            new() { Id = 2, Name = "Moin", Age = 21 },
            new() { Id = 3, Name = "Bill", Age = 18 },
            new() { Id = 4, Name = "Ram", Age = 20 },
            new() { Id = 5, Name = "Ron", Age = 15 },
            new() { Id = 1, Name = "Nam", Age = 13 }
        };

        // SequenceEqual

        var student = new Student { Id = 1, Name = "Bill" };

        var studentList1 = new List<Student> { student };
        var studentList2 = new List<Student> { student };
        var resultSequenceEqual1 = studentList1.SequenceEqual(studentList2); // returns true
        Console.WriteLine($"DemoSequenceEqual1 {resultSequenceEqual1}");

        var std1 = new Student { Id = 1, Name = "Bill" };
        var std2 = new Student { Id = 1, Name = "Bill" };
        var studentList3 = new List<Student> { std1 };
        var studentList4 = new List<Student> { std2 };

        var resultSequenceEqual2 = studentList3.SequenceEqual(studentList4); // returns false
        Console.WriteLine($"DemoSequenceEqual2 {resultSequenceEqual2}");

        var students2 = new List<Student>
        {
            new() { Id = 1, Name = "John", Age = 13 },
            new() { Id = 2, Name = "Moin", Age = 21 },
            new() { Id = 3, Name = "Bill", Age = 18 },
            new() { Id = 4, Name = "Ram", Age = 20 },
            new() { Id = 5, Name = "Ron", Age = 15 },
            new() { Id = 1, Name = "Name Not In Main List", Age = 13 },
            new() { Id = 1, Name = "Nam", Age = 13 }
        };
        var studentList5 = new List<Student>
        {
            new() { Id = 1, Name = "John", Age = 18 },
            new() { Id = 2, Name = "Steve", Age = 15 },
            new() { Id = 3, Name = "Bill", Age = 25 },
            new() { Id = 4, Name = "Ram", Age = 20 },
            new() { Id = 5, Name = "Ron", Age = 19 }
        };

        var studentList6 = new List<Student>
        {
            new() { Id = 1, Name = "John", Age = 18 },
            new() { Id = 2, Name = "Steve", Age = 15 },
            new() { Id = 3, Name = "Bill", Age = 25 },
            new() { Id = 4, Name = "Ram", Age = 20 },
            new() { Id = 5, Name = "Ron", Age = 19 }
        };
        var isEqual = studentList5.SequenceEqual(studentList6, new StudentComparer()); // true
        Console.WriteLine($"DemoSequenceEqual3 {isEqual}");
    }
}