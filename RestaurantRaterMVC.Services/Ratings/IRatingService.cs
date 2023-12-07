using RestaurantRaterMVC.Models.Ratings;

namespace RestaurantRaterMVC.Services.Ratings;
public interface IRatingService
{
    Task<bool> CreateRatingAsync(RatingCreate model);
    Task<List<RatingListItem>> GetRatingsAsync();
    Task<List<RatingListItem>> GetRestaurantRatingsAsync(int restaurantId);
}
