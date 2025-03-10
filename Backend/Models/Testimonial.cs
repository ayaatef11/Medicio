namespace Backend.Models;

public class Testimonial
{
  public int Id{get;set;}
    public string Quote { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
     public Testimonial()
     {

     }
    public Testimonial(int id,string text, string img, string name, string role)
    {
      Id=id;
        Quote = text;
        Image = img;
        Name = name;
        Position = role;
    }
}
