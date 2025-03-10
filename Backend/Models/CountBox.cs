namespace Backend.Models;
public class CountBox
{
  public int Id{get;set;}
    public string Icon { get; set; }
    public int Count { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }

public CountBox()
{

}
  public CountBox(int id,string icon, int count, string title, string description, string link)
    {
      Id=id;
        Icon = icon;
        Count = count;
        Title = title;
        Description = description;
        Link = link;
    }
}
