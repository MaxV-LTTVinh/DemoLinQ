using CoreApiClient.Models.JsonConverters;

namespace DemoLinQ;

public static class DemoContains
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


        // Contains
        var std = new Student { Id = 1, Name = "John", Age = 13 };
        var resultContains1 = students.Contains(std);
        Console.WriteLine($"resultContains1 {resultContains1}");

        var resultContains2 = students.Contains(std, new StudentComparer());
        Console.WriteLine($"resultContains2 {resultContains2}");
    }
}