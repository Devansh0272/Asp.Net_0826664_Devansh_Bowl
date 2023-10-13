using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniqueBowl.Models;

namespace UniqueBowl.Data
{
    public class UniqueBowlContext : DbContext
    {
        public UniqueBowlContext(DbContextOptions<UniqueBowlContext> options)
            : base(options)
        {
        }

        public DbSet<Bowl> Bowl { get; set; }
    }
}
