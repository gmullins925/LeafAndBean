using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeafAndBean.Data;
using LeafAndBean.Models;
using Microsoft.EntityFrameworkCore;

namespace LeafAndBean.Controllers
{
public class HomeController : Controller
	{
		private readonly ApplicationDbContext _context;

		public HomeController(ApplicationDbContext context)
		{
			_context = context;
		}
				public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> Locations()
		{
			return View(await _context.Store.ToListAsync());
		}
		public IActionResult About()
		{
			return View();
		}

		public IActionResult Products()
		{
			return View();
		}
		public IActionResult Store()
		{
			return View();
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
