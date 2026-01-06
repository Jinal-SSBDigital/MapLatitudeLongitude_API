using MapLatitudeLongitude.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace MapLatitudeLongitude.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Museum> Museums { get; set; }
    }
}
