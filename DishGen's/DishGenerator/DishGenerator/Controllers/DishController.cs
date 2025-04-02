using Microsoft.AspNetCore.Mvc;
using DishGenerator.Services;

namespace DishGenerator.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DishController : ControllerBase
	{
		private readonly DishService _dishService;

		public DishController(DishService dishService)
		{
			_dishService = dishService;
		}

		[HttpGet]
		public ActionResult<string> GetRandomDish()
		{
			var dish = _dishService.GetRandomDish();
			return Ok(dish);
		}
	}
}