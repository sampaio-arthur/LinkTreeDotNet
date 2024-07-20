using LinktreeApp.Models;
using LinktreeApp.Services; // Certifique-se de usar o namespace correto
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LinktreeApp.Controllers
{
    public class LinksController : Controller
    {
        private readonly LinkService _linkService;

        public LinksController()
        {
            _linkService = new LinkService();
        }

        public IActionResult Index()
        {
            List<Link> links = _linkService.GetLinks();
            return View(links);
        }
    }
}
