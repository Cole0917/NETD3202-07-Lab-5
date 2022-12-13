using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NETD3202Lab5.Models
{
    public class ProductDetails : DbContext
    {
        // Constructor
        public ProductDetails (DbContextOptions<ProductDetails> options) : base(options) 
        {

        }
        public DbSet<Computer> Computers { get; set; }
    }
}
