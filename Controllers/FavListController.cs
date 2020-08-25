using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _08202020_Lab21Lab25.Models;
using System.Text.Json;

namespace _08202020_Lab21Lab25.Controllers
{
    public class FavListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        List<Movie> movieList = new List<Movie>();
        public IActionResult AddToMovieList(Movie movie)
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
            return View();
        }
    }
}
