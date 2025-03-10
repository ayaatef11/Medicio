namespace Backend.Models;

public class PricingPlan
{
  public int Id{get;set;}
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<Feature> Features { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsAdvanced { get; set; }
    public PricingPlan()
    {

    }
    public PricingPlan(int id,string name, decimal price, List<Feature> features, bool isFeatured = false, bool isAdvanced = false)
    {
      Id=id;
        Name = name;
        Price = price;
        Features = features ?? new List<Feature>();
        IsFeatured = isFeatured;
        IsAdvanced = isAdvanced;
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
