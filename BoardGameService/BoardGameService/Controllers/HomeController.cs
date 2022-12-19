using BoardGameService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BoardGameService.Controllers
{
    public class HomeController : Controller
    {
        List<BoardGame> boardGames = new List<BoardGame>
        {
            new BoardGame(1, "Monopoly", 8, 7, new List<string>() {"Rodzinna, ", "Przyjaciele, ", "Ekonomia, ", "Na każdą okazję "}, "Fajna gra rodzinna i na każdą okazję.", 180, "monopoly.jpg")

        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllBoardGames()
        {
            return View(boardGames);
        }

        public IActionResult Thread()
        {
            var boardGame = boardGames[0];

            return View(boardGame);
        }

        public IActionResult SignUpIn()
        {
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
    }
}