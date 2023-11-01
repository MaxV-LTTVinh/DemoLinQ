using CoreApiClient.Models.JsonConverters;

namespace DemoLinQ;

public static class DemoOrder
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
        // OrderBy and ThenBy
        var resultOrderBy = students
            .OrderBy(e => e.Age)
            .ThenBy(e => e.Name);

        Console.WriteLine($"resultOrderBy {resultOrderBy.ToJson()}");
    }
}