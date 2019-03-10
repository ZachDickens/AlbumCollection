using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Controllers
{
    public class AlbumController : Controller
    {
        IAlbumRepository albumRepository;

        public AlbumController(IAlbumRepository albumRepository)
        {
            this.albumRepository = albumRepository;
        }

        public ViewResult Index()
        {
            IEnumerable<Album> model = albumRepository.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = albumRepository.GetById(id);
            return View(model);
        }

    }
}
