using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace OrderAPI.Data
{
    public class OrderAPIContext : DbContext
    {
        public OrderAPIContext (DbContextOptions<OrderAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Orders> Orders { get; set; } = default!;
        public DbSet<Models.Product> Products { get; set; }
    }
}
