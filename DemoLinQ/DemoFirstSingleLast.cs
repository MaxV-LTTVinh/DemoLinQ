using CoreApiClient.Models.JsonConverters;

namespace DemoLinQ;

internal class DemoFirstSingleLast
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

        // First
        var resultFirst = students.First(e => e.Id == 9); // throw exception
        Console.WriteLine($"resultLast {resultFirst.ToJson()}");

        // FirstOrDefault
        var resultFirstOrDefault = students.FirstOrDefault(e => e.Id == 9);// null
        Console.WriteLine($"resultFirstOrDefault {resultFirstOrDefault.ToJson()}");

        // Single 
        var resultSingle = students.Single(e => e.Id == 13); // throw exception
        Console.WriteLine($"resultSingle {resultSingle.ToJson()}");

        // SingleOrDefault
        var resultSingleOrDefault = students.SingleOrDefault(e => e.Age == 999);// null
        Console.WriteLine($"resultSingleOrDefault {resultSingleOrDefault.ToJson()}");

        // Last
        var resultLast = students.Last(e => e.Id == 9);// throw exception
        Console.WriteLine($"resultLast {resultLast.ToJson()}");

        // LastOrDefault
        var resultLastOrDefault = students.LastOrDefault(e => e.Id == 9); // null
        Console.WriteLine($"resultLastOrDefault {resultLastOrDefault.ToJson()}");
    }
}