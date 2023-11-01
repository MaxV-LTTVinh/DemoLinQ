using CoreApiClient.Models.JsonConverters;

namespace DemoLinQ;

public static class DemoSkipTakePaging
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

        //Skip: Skips elements up to a specified position starting from the first element in a sequence.
        var resultSkip = students.Skip(2);
        Console.WriteLine($"resultSkip {resultSkip.ToJson()}");

        //SkipWhile: Skips elements based on a condition until an element does not satisfy the condition. If the first element itself doesn't satisfy the condition, it then skips 0 elements and returns all the elements in the sequence.
        var resultSkipWhile = students.SkipWhile(e => e.Age < 18);
        Console.WriteLine($"resultSkipWhile {resultSkipWhile.ToJson()}");

        //Take: Takes elements up to a specified position starting from the first element in a sequence.
        var resultTake = students.Take(2);
        Console.WriteLine($"resultTake {resultTake.ToJson()}");

        //TakeWhile: Returns elements from the first element until an element does not satisfy the condition. If the first element itself doesn't satisfy the condition then returns an empty collection.
        var resultTakeWhite = students.SkipWhile(e => e.Age >= 18);
        Console.WriteLine($"resultTakeWhite {resultTakeWhite.ToJson()}");

        // Mix Skip Take for Paging
        // page 2 and 3 item
        var pageIndex = 2;
        var pageSize = 3;
        var resultPaging = students
            .Where(e => e.Age <= 20)
            .OrderBy(e => e.Age)
            .ThenByDescending(e => e.Name)
            //.Skip((pageIndex - 1) * pageSize)
            //.Take(pageSize)
            ;
        Console.WriteLine($"resultPaging {resultPaging.ToJson()}");
    }
}