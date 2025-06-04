using System.Text.Json;
using System;
using System.IO;
using System.Collections.Generic;

public static class Json
{
    public static List<Passage> LoadFromJson(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return new List<Passage>();
        }

        string json = File.ReadAllText(filePath);

        var options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        return JsonSerializer.Deserialize<List<Passage>>(json, options) ?? new List<Passage>();
    }
}
