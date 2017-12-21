using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExampleASPNetCore.Models
{
    public class ExampleASPNetCoreContext : DbContext
    {
        public ExampleASPNetCoreContext (DbContextOptions<ExampleASPNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ExampleASPNetCore.Models.Movie> Movie { get; set; }
    }
}
