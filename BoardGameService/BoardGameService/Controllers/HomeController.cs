using BoardGameService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BoardGameService.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;

        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllBoardGames()
        {
            var games = _dataContext.Boards
                .ToList();

            return View(games);
        }

        public IActionResult Thread(int id)
        {
            var game = _dataContext.Boards
                .Find(id);

            ViewBag.game = game;

            if(game == null)
                return NotFound();

            return View(game);
        }

        public IActionResult CreateComment(int id)
        {
            var game = _dataContext.Boards
                .Find(id);
            ViewBag.game = game;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateComment([Bind("BoardGameId,Author,Rating,Content")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.Created = DateTime.Now;
                var game = _dataContext.Boards
                    .Find(comment.BoardGameId);
                ViewBag.game = game;

                _dataContext.Comments.Add(comment);
                _dataContext.SaveChanges();

                return View("AddedComment", comment);
            }
            else
            {
                var game = _dataContext.Boards
                    .Find(comment.BoardGameId);
                ViewBag.game = game;
                return View(comment);
            }
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