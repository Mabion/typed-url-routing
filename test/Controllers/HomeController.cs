﻿namespace test.Controllers
{
	using System.Web.Mvc;
	using test.Models;

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			return View();
		}

		public ActionResult ShowTwoParameters(int first, string second)
		{
			return View(new string[] { first.ToString(), second });
		}

		public ActionResult ShowTwoParametersPlusQuery(int first, string second, string third, string forth)
		{
			return View(new string[] { first.ToString(), second, third, forth });
		}

		[HttpGet]
		public ActionResult ModelParameter(Abc abc = null)
		{
			return View(abc);
		}
	}
}
