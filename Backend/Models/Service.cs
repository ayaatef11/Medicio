namespace Backend.Models;

public class Service
{
  public int Id{get;set;}
    public string Icon { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }
    public Service()
    {

    }
    public Service(int id,string icon, string title, string description, int delay)
    {
      Id=id;
        Icon = icon;
        Title = title;
        Description = description;
        Value = delay;
    }
}
