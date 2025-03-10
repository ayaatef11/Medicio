namespace Backend.Models;

public class UsefulLink
{
  public int Id{get;set;}
    public string Name { get; set; }
    public string Url { get; set; }
     public usefulLink()
     {

     }
    public UsefulLink(int id,string name, string url)
    {
      Id=id;
        Name = name;
        Url = url;
    }
}
