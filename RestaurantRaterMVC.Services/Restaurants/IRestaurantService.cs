using RestaurantRaterMVC.Models.Restaurants;

namespace RestaurantRaterMVC.Services.Restaurants;
public interface IRestaurantService
{
    Task<IEnumerable<RestaurantListItem>> GetAllRestaurantsAsync();
    Task<bool> CreateRestaurantAsync(RestaurantCreate model);
    Task<RestaurantDetail?> GetRestaurantAsync(int id);
    Task<bool> UpdateRestaurantAsync(RestaurantEdit model);
    Task<bool> DeleteRestaurantAsync(int id);
}