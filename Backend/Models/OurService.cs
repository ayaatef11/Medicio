namespace Backend.Models;

public class OurService
{
  public int Id{get;set;}
    public string Name { get; set; }
    public string Url { get; set; }
    public OurService()
    {

    }
    public OurService(int id,string name, string url)
    {
      Id=id;
        Name = name;
        Url = url;
    }
}
