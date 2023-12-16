using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using news11.Models;

namespace news11.Data
{
    public class news11Context : DbContext
    {
        public news11Context (DbContextOptions<news11Context> options)
            : base(options)
        {
        }

        public DbSet<news11.Models.NewsArticle> NewsArticle { get; set; } = default!;
    }
}
