public class IconBox
{
    public string Icon { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Delay { get; set; }

    // Constructor
    public IconBox(string icon, string title, string description, int delay)
    {
        Icon = icon;
        Title = title;
        Description = description;
        Delay = delay;
    }
}
