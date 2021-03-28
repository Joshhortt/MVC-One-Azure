using Microsoft.AspNetCore.Mvc;
using MvcOne.Data;
using MvcOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcOne.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _db;

		public CategoryController(ApplicationDbContext db)
		{
			_db = db;
		}


		public IActionResult Index()
		{
			IEnumerable<Category> objList = _db.Category;
			return View(objList);
		}
	}
}
