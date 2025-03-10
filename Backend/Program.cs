using System.Reflection;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//for camle case litters in json and classes
builder.Services.AddControllers() .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

// using (var scope = app.Services.CreateScope())
// {
//     var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
// var dbSetProperties = context.GetType()
//     .GetProperties(BindingFlags.Public | BindingFlags.Instance)
//     .Where(p => p.PropertyType.IsGenericType &&
//                 p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>));

// foreach (var property in dbSetProperties)
// {
//     string entityName = property.Name; // Get entity  with s
//     string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(),$"Data/DataSeeding/{entityName}.json");//wiht s
// //check path??????????
//     if (!File.Exists(jsonFilePath))
//     {
//         Console.WriteLine($"Skipping {entityName}: File not found.");
//         continue;
//     }

//     var entityType = property.PropertyType.GetGenericArguments()[0]; // Get entity type
//     var dbSet = property.GetValue(context) as IQueryable<object>; // Cast to IQueryable<object>

//     if (dbSet == null)
//     {
//         Console.WriteLine($"Skipping {entityName}: Could not access DbSet.");
//         continue;
//     }

//     var dataList = JsonConvert.DeserializeObject(File.ReadAllText(jsonFilePath),
//         typeof(List<>).MakeGenericType(entityType));

//     if (dataList is IEnumerable<object> entityList && entityList.Any())
//     {
//         context.AddRange(entityList);
//     }
// }

// context.SaveChanges(); // Save all seeded data


// }


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseAuthorization();
app.MapControllers();
app.Run();
