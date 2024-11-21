using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProductAPI.Data
{
    public class ProductAPIContext : DbContext
    {
        public ProductAPIContext (DbContextOptions<ProductAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Product> Product { get; set; } = default!;
    }
}
