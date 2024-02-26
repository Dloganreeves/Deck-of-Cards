using Deck_of_Cards_lab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Deck_of_Cards_lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShuffleDeck()
        {
            DeckModel deck = DeckDAL.GetDeck();
            return  RedirectToAction("Draw");
            
        }

        public IActionResult Draw()
        {
            DrawModel deck = DeckDAL.Draw();
            return View(deck);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
