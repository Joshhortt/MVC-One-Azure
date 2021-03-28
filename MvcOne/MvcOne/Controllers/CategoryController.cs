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

		// GET - CREATE
		public IActionResult Create()
		{
			return View();  // we don't need to pass anything to the view. Can be empty.
		}

		//POST - CREATE
		[HttpPost] // Attribute of POST
		[ValidateAntiForgeryToken]  // add built-in anti-foregery token 
		public IActionResult Create(Category obj)
		{  // object to add to the db
			if (ModelState.IsValid)
			{
				_db.Category.Add(obj);
				_db.SaveChanges();  // save changes method in the Sql db 
				return RedirectToAction("Index");  // return to the action method
			}
			return View(obj);
		}
	}
}
