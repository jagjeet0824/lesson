using comp2007amMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comp2007amMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            // create mock list of Genres using the Genre model
            var genres = new List<Genre>();

            for (int i = 1; i < 11; i++)
            {
                genres.Add(new Genre { Name = "Genre " + i.ToString() });
            }

            // pass the genres in the ViewBag
            //ViewBag.genres = genres;

            return View(genres);
        }

        // GET: Store/Details/[Genre]
        public ActionResult Details(string genre)
        {
            if (genre == null)
            {
                return View("Error");
                //return View("Contact");
                //return RedirectToAction("Contact", "Home");
            }
            ViewBag.Genre = genre;

            // return mock album list
            var albums = new List<Album>();

            for (int i = 1; i < 4; i++)
            {
                albums.Add(new Album { Title = "Album " + i.ToString(), AlbumArtUrl = "/Content/Images/placeholder.gif", Price= 8.99 });
            }

            return View(albums);
        }
    }
}