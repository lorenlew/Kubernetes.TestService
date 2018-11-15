using System;
using Microsoft.AspNetCore.Mvc;

namespace Kubernetes.TestService.Api.Home
{
	[Route("/")]
	[Controller]
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{

			return View("~/Home/Home.cshtml", $"You've hit {Environment.MachineName} \n");
		}
	}
}
