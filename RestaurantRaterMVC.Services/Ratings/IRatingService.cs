using RestaurantRaterMVC.Models.Ratings;

namespace RestaurantRaterMVC.Services.Ratings;
public interface IRatingService
{
    Task<List<RatingListItem>> GetRatingsAsync();
    Task<List<RatingListItem>> GetRestaurantRatingsAsync(int restaurantId);
}
