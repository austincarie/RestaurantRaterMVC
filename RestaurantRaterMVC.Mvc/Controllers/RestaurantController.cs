using Microsoft.AspNetCore.Mvc;
using RestaurantRaterMVC.Models.Restaurants;
using RestaurantRaterMVC.Services.Restaurants;

namespace RestaurantRaterMVC.Mvc.Controllers;
public class RestaurantController : Controller
{
    private IRestaurantService _service;
    public RestaurantController(IRestaurantService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        List<RestaurantListItem> restaurants = (List<RestaurantListItem>)await _service.GetAllRestaurantsAsync();
        return View(restaurants);
    }
}