using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

public static class ModelBuilderExtension
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        string jsonDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Data/DataSeeding");

        var jsonFiles = Directory.GetFiles(jsonDirectoryPath, "*.json");

        foreach (var file in jsonFiles)
        {
            var entityName = Path.GetFileNameWithoutExtension(file).TrimEnd('s'); // Extract filename without extension

            var jsonData = File.ReadAllText(file);

            Type entityType = Type.GetType($"Backend.Models.{entityName}");
            if (entityType == null) continue; // Skip if entity type is not found
            var data = JsonConvert.DeserializeObject(jsonData, typeof(List<>).MakeGenericType(entityType));

            if (data != null)
            {
                modelBuilder.Entity(entityType).HasData((IEnumerable<object>)data);
            }
        }
    }
}
