using Microsoft.IdentityModel.Tokens;
using RestaurantRaterMVC.Data;

namespace RestaurantRaterMVC.Services.Restaurants;
public class RestaurantService : IRestaurantService
{
    private RestaurantDbContext _context;
    public RestaurantService(RestaurantDbContext context)
    {
        _context = context;
    }
}