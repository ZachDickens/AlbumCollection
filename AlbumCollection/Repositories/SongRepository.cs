using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;

namespace AlbumCollection.Repositories
{
    public class SongRepository : ISongRepository
    {
        AlbumContext db;

        public SongRepository(AlbumContext db)
        {
            this.db = db;
        }

        public void AddSong(Song song)
        {
            db.Songs.Add(song);
            db.SaveChanges();
        }

        public IEnumerable<Song> GetAll()
        {
            return db.Songs.ToList();
        }

        public Song GetAll(Song song)
        {
            throw new NotImplementedException();
        }

        public Song GetById(int id)
        {
            return db.Songs.Single(song => song.SongId == id);
        }
    }
}
