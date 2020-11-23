using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MoviesDay2.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext() : base("name=efMovie")
        {

        }
        public DbSet<Theater> theaters { get; set; }

        public System.Data.Entity.DbSet<MoviesDay2.Models.Screen> Screens { get; set; }
    }
}