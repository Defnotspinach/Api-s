using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DishGen.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DishController : Controller
	{
		private static readonly List<string> Dishes = new List<string>
		{
			"Spaghetti Carbonara",
			"Chicken Alfredo",
			"Beef Tacos",
			"Vegetable Stir-fry",
			"Margherita Pizza",
			"Grilled Salmon",
			"Vegetarian Curry",
			"Chicken Caesar Salad",
			"Pasta Primavera",
			"Sushi Rolls",
			"Shakshuka",
			"Beef Stew"
		};

		[HttpGet("generate")]
		public IActionResult Get()
		{
			Random rnd = new Random();
			int dishIndex = rnd.Next(Dishes.Count); 
			string generateDish = Dishes[dishIndex];
			return Ok(new { Dish = generateDish });
		}

		[HttpPost]
		public IActionResult Post([FromBody] string dish) 
		{
			Dishes.Add(dish); 
			return Ok(new { Dishes = Dishes });
		}
	}
}
