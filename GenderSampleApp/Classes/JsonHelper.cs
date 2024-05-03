#nullable disable
using System.Text.Json;
using GenderSampleApp.Models;

namespace GenderSampleApp.Classes;

/// <summary>
/// Serialize and deserialize a Person object
/// </summary>
public static class JsonHelper
{
    private static JsonSerializerOptions Options =>
        new()
        {
            WriteIndented = true,
            IgnoreReadOnlyProperties = true
        };

    public static string SerializePerson(List<Person> person)
    {
        return JsonSerializer.Serialize(person, Options);
    }
    public static List<Person> DeserializePerson(string json)
    {
        return JsonSerializer.Deserialize<List<Person>>(json);
    }
}