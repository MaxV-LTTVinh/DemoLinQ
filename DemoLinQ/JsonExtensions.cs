
using System.Text.Json.Serialization;
using System.Text.Json;

namespace CoreApiClient.Models.JsonConverters;

public static class JsonExtensions
{
    public static string ToJson(this object source)
    {

        return JsonSerializer.Serialize(source);
    }

    public static T? ToObject<T>(this string source)
    {

        return JsonSerializer.Deserialize<T>(source);
    }
}