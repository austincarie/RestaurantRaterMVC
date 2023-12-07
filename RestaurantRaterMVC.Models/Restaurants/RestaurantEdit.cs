using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace RestaurantRaterMVC.Models.Restaurants;
public class RestaurantEdit
{
    [Required]
    public int Id {get; set;}

    [Required, StringLength(100)]
    public string Name {get; set;} = string.Empty;

    [Required, StringLength(100)]
    public string Location {get; set;} = string.Empty;
}