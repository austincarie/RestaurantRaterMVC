using System.ComponentModel.DataAnnotations;

namespace RestaurantRaterMVC.Models.Ratings;
public class RatingListItem
{
    [Display(Name = "Restaurant")]
    public string? RestaurantName {get; set;}

    [Display(Name ="Rating")]
    public double Score {get; set;}
}