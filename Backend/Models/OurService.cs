public class OurService
{
    public string Name { get; set; }
    public string Url { get; set; }

    // Constructor
    public OurService(string name, string url)
    {
        Name = name;
        Url = url;
    }
}
