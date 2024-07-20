using Microsoft.AspNetCore.Mvc;
using LinktreeApp.Models;
using System.Collections.Generic;

namespace LinktreeApp.Controllers
{
    public class LinksController : Controller
    {
        private static List<Link> links = new List<Link>
        {
            new Link { Id = 1, Title = "Google", Url = "https://www.google.com" },
            new Link { Id = 2, Title = "YouTube", Url = "https://www.youtube.com" }
        };

        public IActionResult Index()
        {
            return View(links);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Link link)
        {
            link.Id = links.Count + 1;
            links.Add(link);
            return RedirectToAction("Index");
        }
    }
}
