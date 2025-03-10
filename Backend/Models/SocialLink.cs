namespace Backend.Models;

public class SocialLink
{
  public int Id{get;set;}
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
     public SocialLink()
     {

     }
     public SocialLink(int id,string name, string url, string icon)
    {
      Id=id;
        Name = name;
        Url = url;
        Icon = icon;
    }
}
