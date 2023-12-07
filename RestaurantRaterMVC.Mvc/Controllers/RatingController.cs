using Microsoft.AspNetCore.Mvc;
using RestaurantRaterMVC.Models.Ratings;
using RestaurantRaterMVC.Services.Ratings;

namespace RestaurantRaterMVC.Mvc.Controllers;
public class RatingController : Controller
{
    private readonly IRatingService _service;
    public RatingController(IRatingService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        List<RatingListItem> model = await _service.GetRatingsAsync();
        return View(model);
    }
}