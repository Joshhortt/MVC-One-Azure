using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcOne.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()  // action is added here bit is necessary to add view in _Layout.cshtml
		{
			return View();
		}
	}
}
