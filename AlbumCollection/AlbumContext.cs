using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(

                new Album()
                {
                    AlbumId = 1,
                    AlbumName = "Hybrid Theory",
                    ArtistName = "Linkin Park"
                },

                new Album()
                {
                    AlbumId = 2,
                    AlbumName = "Meteora",
                    ArtistName = "Linkin Park"
                },

                new Album()
                {
                    AlbumId = 3,
                    AlbumName = "Minutes to Midnight",
                    ArtistName = "Linkin Park"
                });

            modelBuilder.Entity<Song>().HasData(

                new Song()
                {
                    AlbumId = 1,
                    SongId = 1,
                    SongName = "In the End"
                },

                new Song()
                {
                    AlbumId = 1,
                    SongId = 2,
                    SongName = "Crawling"
                },

                new Song()
                {
                    AlbumId = 2,
                    SongId = 3,
                    SongName = "Somewhere I Belong"
                },

                new Song()
                {
                    AlbumId = 2,
                    SongId = 4,
                    SongName = "Faint"
                },

                new Song()
                {
                    AlbumId = 3,
                    SongId = 5,
                    SongName = "What I've Done"
                },

                new Song()
                {
                    AlbumId = 3,
                    SongId = 6,
                    SongName = "Leave Out All The Rest"
                });

            base.OnModelCreating(modelBuilder);

        }
    }
}
