namespace Backend.Models;

public class Testimonial
{
  public int Id{get;set;}
    public string Text { get; set; }
    public string Img { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
     public Testimonial()
     {

     }
    public Testimonial(int id,string text, string img, string name, string role)
    {
      Id=id;
        Text = text;
        Img = img;
        Name = name;
        Role = role;
    }
}
