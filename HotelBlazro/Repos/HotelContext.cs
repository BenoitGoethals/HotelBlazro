using System.Reflection;
using HotelBlazro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HotelBlazro.Repos
{
    public class HotelContext:DbContext
    {
        private readonly IConfiguration _config;
        public HotelContext(IConfiguration config, DbContextOptions<HotelContext> options)
            : base(options) {
            _config = config ?? throw new System.ArgumentNullException(nameof(config));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Supplement> Supplements { get; set; }
    }
}