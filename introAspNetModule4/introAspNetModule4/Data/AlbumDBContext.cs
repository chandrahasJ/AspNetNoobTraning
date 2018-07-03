using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace introAspNetModule4.Models
{
    public class AlbumDBContext : DbContext
    {
        public AlbumDBContext (DbContextOptions<AlbumDBContext> options)
            : base(options)
        {
        }

        public DbSet<introAspNetModule4.Models.Album> Album { get; set; }
    }
}
