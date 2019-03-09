using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
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
            this.albumRepo = albumRepo;
        }

        public ViewResult Index()
        {
            var model = albumRepo.GetAll();
            return View(model);
        }

    }
}
