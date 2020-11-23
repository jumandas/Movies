using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MoviesDay2.Models
{
    public class MovieContext1:DbContext
    {
            public MovieContext1() : base("name=efMovie")
            {

            }
            public DbSet<Screen> screens { get; set; }
        }
    }