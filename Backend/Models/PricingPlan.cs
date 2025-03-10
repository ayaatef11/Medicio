namespace Backend.Models;

public class PricingPlan
{
  public int Id{get;set;}
    public string Name { get; set; }
    public int Price { get; set; }
    public List<Feature> Features { get; set; }
    public bool Featured { get; set; }
    public bool Advanced { get; set; }///check if i need to make true and false big letters or not
    public PricingPlan()
    {

    }
    public PricingPlan(int id,string name, int price, List<Feature> features, bool isFeatured = false, bool isAdvanced = false)
    {
      Id=id;
        Name = name;
        Price = price;
        Features = features ?? new List<Feature>();
        Featured = isFeatured;
        Advanced = isAdvanced;
    }
}

public class Feature
{
   public int Id{get;set;}
    public string Text { get; set; }
    public bool Available { get; set; }
    Feature(){

    }
    public Feature(int id,string text, bool available)
    {
      Id=id;
        Text = text;
        Available = available;
    }
}
