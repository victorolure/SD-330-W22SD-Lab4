using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SD_330_W22SD_Lab4.Models;

namespace SD_330_W22SD_Lab4.Data
{
    public class SD_330_W22SD_Lab4Context : DbContext
    {
        public SD_330_W22SD_Lab4Context (DbContextOptions<SD_330_W22SD_Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Address> Address { get; set; }
    }
}
