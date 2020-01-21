using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using salesWebMvc.Models;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<salesWebMvc.Models.Department> Department { get; set; }

        public DbSet<Seller> Seller { get; set; }

        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
