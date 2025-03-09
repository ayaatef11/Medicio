// public class PricingPlan
// {
//     public string Name { get; set; }
//     public decimal Price { get; set; }
//     public List<Feature> Features { get; set; }
//     public bool IsFeatured { get; set; }
//     public bool IsAdvanced { get; set; }

//     // Constructor
//     public PricingPlan(string name, decimal price, List<Feature> features, bool isFeatured = false, bool isAdvanced = false)
//     {
//         Name = name;
//         Price = price;
//         Features = features ?? new List<Feature>(); // Ensuring it's not null
//         IsFeatured = isFeatured;
//         IsAdvanced = isAdvanced;
//     }
// }

// // Nested Feature class
// public class Feature
// {
//     public string Text { get; set; }
//     public bool Available { get; set; }

//     // Constructor
//     public Feature(string text, bool available)
//     {
//         Text = text;
//         Available = available;
//     }
// }
