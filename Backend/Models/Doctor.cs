using System.Collections.Generic;
namespace Backend.Models;

public class Doctor
{
  public int Id{get;set;}
    public required string Name { get; set; }
    public required string Specialty { get; set; }
    public required string Image { get; set; }
    public List<SocialLink> Socials { get; set; }
     public Doctor()
     {

     }
    public Doctor(int id,string name, string specialty, string image, List<SocialLink> socials)
    {
      Id=id;
        Name = name;
        Specialty = specialty;
        Image = image;
        Socials = socials ?? new List<SocialLink>();
    }
}
