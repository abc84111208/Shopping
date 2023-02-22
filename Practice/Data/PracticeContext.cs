using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.Data
{
    public class PracticeContext : DbContext
    {
        public PracticeContext (DbContextOptions<PracticeContext> options)
            : base(options)
        {
        }

        public DbSet<Practice.Models.Product> Product { get; set; } = default!;
    }
}
