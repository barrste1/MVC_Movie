using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using _08202020_Lab21Lab25.Models;
using System.Text.Json;

namespace _08202020_Lab21Lab25.Controllers
{
    public class HomeController : Controller
    {
        #region Logger
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        #endregion

        public IActionResult Registration()
        {
            return View("Registration",new Movie());
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Clutter
        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion

        List<Movie> movieList = new List<Movie>();

        public IActionResult Register(Movie movie)
        {
            if (ModelState.IsValid)
            {
                string movieListJSON = HttpContext.Session.GetString("favMovieSession") ?? "EmptySession";
                if (movieListJSON != "EmptySession")
                {

                    //using System.Text.Json;
                    //This turns the string of JSON into List of individual Book Objects
                    movieList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
                }
                //Update the bookList by adding the book from the form
                movieList.Add(movie);

                //Update/Save the new book into the session
                //Turns our List of objects (books) into a string that the session can keep
                movieListJSON = JsonSerializer.Serialize(movieList);
                //sets the session to the updated JSON
                HttpContext.Session.SetString("favMovieSession", movieListJSON);

                return View("Result", movie);

            }
            else
            {
                return View("Registration", movie);
            }
        }

        public IActionResult DisplayFavList()
        {
            return View("DisplayFavList");
        }

    }
}
