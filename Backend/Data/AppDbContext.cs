using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Backend.Models;
namespace Backend.Data{
public class AppDbContext:DbContext{
  public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
  {

  }
  public DbSet<CountBox>CountBoxs{get;set;}
  public DbSet<Department>Departments{get;set;}
  public DbSet<Doctor>Doctors{get;set;}
  public DbSet<IconBox>IconBoxs{get;set;}
  public DbSet<OurService>OurServices{get;set;}
  public DbSet<PricingPlan>PricingPlans{get;set;}
  public DbSet<Service>Services{get;set;}
  public DbSet<Slide>Slides{get;set;}
  public DbSet<SocialLink>SocialLinks{get;set;}
  public DbSet<Testimonial>Testimonials{get;set;}
  public DbSet<UsefulLink>UsefulLinks{get;set;}
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    base.OnModelCreating(modelBuilder);
    // modelBuilder.SeedData();
  }
}

}
