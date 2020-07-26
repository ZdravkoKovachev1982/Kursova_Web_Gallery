using Microsoft.EntityFrameworkCore;


namespace Kursova_Web_Gallery.Models
{
   
        public class ImageDbContext : DbContext
        {
            public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
            { }

            public DbSet<ImageModel> Images { get; set; }
        }

    }

