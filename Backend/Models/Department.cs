namespace Backend.Models;

public class Department
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Active { get; set; }

public Department()
{

}
    public Department(string id, string name, string description, bool active)
    {
        Id = id;
        Name = name;
        Description = description;
        Active = active;
    }
}
