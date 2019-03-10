using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        ISongRepository songRepository;

        public SongController(ISongRepository songRepository)
        {
            this.songRepository = songRepository;
        }
        public ViewResult Index()
        {
            IEnumerable<Song> model = songRepository.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = songRepository.GetById(id);
            return View(model);
        }
        [HttpGet]
        public ViewResult AddSong(int id)
        {
            var newSong = new Song()
            {
                AlbumId = id
            };

            return View(newSong);
        }

        [HttpPost]
        public ActionResult AddSong(Song song)
        {
            songRepository.AddSong(song);
            return RedirectToAction("../Album/Details/" + song.AlbumId, "Album");
        }

    }
}
