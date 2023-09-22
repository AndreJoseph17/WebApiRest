using ApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRest.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}