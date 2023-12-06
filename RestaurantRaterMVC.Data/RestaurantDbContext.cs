using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using RestaurantRaterMVC.Data.Entities;
namespace RestaurantRaterMVC.Data;
public class RestaurantDbContext : DbContext
{
    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
        : base(options) { }

    public DbSet<RestaurantEntity> Restaurants {get; set;} = null!;
    public DbSet<RatingEntity> Ratings {get; set;} = null!;
}