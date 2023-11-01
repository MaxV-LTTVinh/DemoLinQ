using CoreApiClient.Models.JsonConverters;

namespace DemoLinQ;

internal class DemoExcept
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

        // Except: The Except() method requires two collections. It returns a new collection with elements from the first collection which do not exist in the second collection (parameter collection).
        var resultExcept1 = students2.Except(students);
        Console.WriteLine($"resultExcept1 {resultExcept1.ToJson()}");

        var resultExcept2 = students2.Except(students, new StudentComparer());
        Console.WriteLine($"resultExcept2 {resultExcept2.ToJson()}");
    }
}