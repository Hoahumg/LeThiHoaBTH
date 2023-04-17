
using System.Net.Mime;
using BTH1004.Models;
using Microsoft.EntityFrameworkCore;

namespace BTH1004.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set; }
    }
}