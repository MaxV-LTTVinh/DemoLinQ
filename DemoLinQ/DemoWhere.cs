using CoreApiClient.Models.JsonConverters;

namespace DemoLinQ;

public static class DemoWhere
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

        // Where 
        var resultByWhere1 = students.Where(e => e.Id == 1);
        Console.WriteLine($"resultTakeWhite {resultByWhere1.ToJson()}");
        var resultByWhere2 = students.Where(e => (e.Age == 13 && e.Name == "Nam") || e.Name == "Ron");
        Console.WriteLine($"resultTakeWhite {resultByWhere2.ToJson()}");
    }
}