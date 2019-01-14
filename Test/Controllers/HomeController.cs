using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "This is a practical skills test for potential candidates.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Hi!";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		[HttpPost]
		public IActionResult Shop([FromBody]IList<OrderItem> order)
		{
			var store = new FoodStore();
			store.AddProvider(new FoodProvider<Meat>());
			store.AddProvider(new FoodProvider<Vegetable>());
			store.AddProvider(new FoodProvider<Fruit>());

			var food = new List<IFood>();
			foreach(var item in order)
			{
				food.AddRange(store.BuyFood(item.Type, item.Count));
			}

			IFoodConsumer person = new Person();

			return Json(new{ message = person.EatFood(food) });
		}
	}
}
