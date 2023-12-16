using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace news11.Data
{
    using Microsoft.EntityFrameworkCore;
    using news11.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<NewsArticle> NewsArticles { get; set; }
    }
}