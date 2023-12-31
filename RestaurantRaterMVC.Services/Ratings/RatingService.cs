using Microsoft.EntityFrameworkCore;
using RestaurantRaterMVC.Data;
using RestaurantRaterMVC.Data.Entities;
using RestaurantRaterMVC.Models.Ratings;

namespace RestaurantRaterMVC.Services.Ratings;
public class RatingService : IRatingService
{
    private readonly RestaurantDbContext _context;
    public RatingService(RestaurantDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateRatingAsync(RatingCreate model)
    {
        RatingEntity entity = new()
        {
            RestaurantId = model.RestaurantId,
            Score = model.Score
        };

        _context.Ratings.Add(entity);
        return await _context.SaveChangesAsync() == 1;
    }
    
    public async Task<List<RatingListItem>> GetRatingsAsync()
    {
        var ratings = await _context.Ratings
            .Include(r => r.Restaurant)
            .Select(r => new RatingListItem
            {
                RestaurantName = r.Restaurant.Name,
                Score = r.Score
            })
            .ToListAsync();

        return ratings;
    }

    public async Task<List<RatingListItem>> GetRestaurantRatingsAsync(int restaurantId)
    {
        var ratings = await _context.Ratings
            .Include(r => r.Restaurant)
            .Where(r => r.RestaurantId == restaurantId)
            .Select(r => new RatingListItem
            {
                RestaurantName = r.Restaurant.Name,
                Score = r.Score
            })
            .ToListAsync();

        return ratings;
    }
}