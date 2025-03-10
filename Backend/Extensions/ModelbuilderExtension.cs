using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

public static class ModelBuilderExtension
{
    public static void SeedData(this ModelBuilder modelBuilder, string jsonDirectoryPath)
    {
        if (!Directory.Exists(jsonDirectoryPath))
            throw new DirectoryNotFoundException($"The directory '{jsonDirectoryPath}' does not exist.");

        var jsonFiles = Directory.GetFiles(jsonDirectoryPath, "*.json");

        foreach (var file in jsonFiles)
        {
            var entityName = Path.GetFileNameWithoutExtension(file); // Extract filename without extension

            var jsonData = File.ReadAllText(file);

            Type entityType = Type.GetType($"Backend.Models.{entityName}s");
            if (entityType == null) continue; // Skip if entity type is not found

            // Deserialize JSON to the appropriate object type
            var data = JsonConvert.DeserializeObject(jsonData, typeof(List<>).MakeGenericType(entityType));

            // Seed the data dynamically
            if (data != null)
            {
                modelBuilder.Entity(entityType).HasData((IEnumerable<object>)data);
            }
        }
    }
}
