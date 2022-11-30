using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBapp.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> Options) : base(Options)
        {
        
        }

        public virtual DbSet<Movies> movies { get; set; }
        public virtual DbSet<Actors> actors {get; set;}
        public virtual DbSet<Producers> producers { get; set; }
    }
}
