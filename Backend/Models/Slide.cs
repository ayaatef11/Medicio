namespace Backend.Models;

public class Slide
{
  public int Id{get;set;}
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }

    public Slide()
    {

    }
    public Slide(int id,string image, string title, string description, string link)
    {
      Id=id;
        Image = image;
        Title = title;
        Description = description;
        Link = link;
    }
}
