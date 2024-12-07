using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [RouteArea("PostArea")]
    [RoutePrefix("n")]
    public class MovieController : Controller
    {
        // GET: Movie
        static List<Movie> movies = new List<Movie>
        {
            new Movie{MovieId=101,Title="MI:1",Lang = "English", Actor="Tom Cruise",Director="A",ReleaseYear = 1996},
            new Movie{MovieId=102,Title="MI:2",Lang = "Hindi", Actor="Tom Cruise",Director="B",ReleaseYear = 2000},
            new Movie{MovieId=103,Title="MI:3",Lang = "English", Actor="Tom Cruise",Director="C",ReleaseYear = 2006},
            new Movie{MovieId=104,Title="MI:4",Lang = "English", Actor="Tom Cruise",Director="D",ReleaseYear = 2011},
            new Movie{MovieId=105,Title="MI:5",Lang = "English", Actor="Tom Cruise",Director="E",ReleaseYear = 2015},
            new Movie{MovieId=106,Title="MI:6",Lang = "English", Actor="Tom Cruise",Director="F",ReleaseYear = 2018},
            new Movie{MovieId=107,Title="MI:7",Lang = "English", Actor="Tom Cruise",Director="G",ReleaseYear = 2021},
            new Movie{MovieId=108,Title="MI:8",Lang = "English", Actor="Tom Cruise",Director="H",ReleaseYear = 2025},
        };

        [Route("Show")]
        public ActionResult Index()
        {
            return View(movies);
        }
        
        public ViewResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Movie movie) 
        {
            movies.Add(movie);
            return RedirectToAction("Index");
        }

        public ActionResult Find()
        {
            return View();
        }

        //[Route("Sea/{Title}")]
        public ActionResult Search(string Title)
        {
            var m = movies.SingleOrDefault(p => p.Title == Title);
            return View(m);
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            foreach (var item in movies)
            {
                if(item.MovieId == id)
                {
                    movies.Remove(item);
                    break;
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            return View();
        }
    }
}