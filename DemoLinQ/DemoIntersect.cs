using CoreApiClient.Models.JsonConverters;

namespace DemoLinQ;

public static class DemoIntersect
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

        // Intersect: The Intersect extension method requires two collections. It returns a new collection that includes common elements that exists in both the collection. Consider the following example.
        var resultIntersect1 = students2.Intersect(students);
        Console.WriteLine($"resultIntersect1 {resultIntersect1.ToJson()}");

        var resultIntersect2 = students2.Intersect(students, new StudentComparer());
        Console.WriteLine($"resultIntersect2 {resultIntersect2.ToJson()}");
    }
}