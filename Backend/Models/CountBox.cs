public class CountBox
{
    public string Icon { get; set; }
    public int Count { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }

    // Constructor
    public CountBox(string icon, int count, string title, string description, string link)
    {
        Icon = icon;
        Count = count;
        Title = title;
        Description = description;
        Link = link;
    }
}
