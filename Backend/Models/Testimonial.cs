public class Testimonial
{
    public string Text { get; set; }
    public string Img { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }

    // Constructor
    public Testimonial(string text, string img, string name, string role)
    {
        Text = text;
        Img = img;
        Name = name;
        Role = role;
    }
}
