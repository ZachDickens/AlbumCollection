using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        AlbumContext db;

        public AlbumRepository(AlbumContext db)
        {
            this.db = db;
        }

        public Album GetbyID(int id)
        {
            return db.Albums.Single(album => album.AlbumId == id);
        }

        public Album GetAll()
        {
            return db.Albums.ToList();
        }
        public List<Song> Songs { get; set; }


    }
}
