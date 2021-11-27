using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chindris_Alexandru_Lab8.Models;

namespace Chindris_Alexandru_Lab8.Data
{
    public class Chindris_Alexandru_Lab8Context : DbContext
    {
        public Chindris_Alexandru_Lab8Context (DbContextOptions<Chindris_Alexandru_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Chindris_Alexandru_Lab8.Models.Book> Book { get; set; }

        public DbSet<Chindris_Alexandru_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Chindris_Alexandru_Lab8.Models.Category> Category { get; set; }
    }
}
