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

        
    }
}
