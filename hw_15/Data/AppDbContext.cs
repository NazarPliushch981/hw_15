using System.Collections.Generic;
using hw_15.Models;
using Microsoft.EntityFrameworkCore;

namespace hw_15.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
    }
}