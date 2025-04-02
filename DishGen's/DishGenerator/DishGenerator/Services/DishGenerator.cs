using System;
using System.Collections.Generic;
using System.Linq;

namespace DishGenerator.Services
{
	public class DishService
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

		private readonly Random _random = new Random();

		public string GetRandomDish()
		{
			int index = _random.Next(Dishes.Count);
			return Dishes[index];
		}
	}
}
