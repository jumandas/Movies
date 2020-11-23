using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesDay2.Models
{
    [Table("tblScreen")]
    public class Screen
    {
        [Key]
        public int sid { get; set; }


        public int? tid { get; set; }

        [ForeignKey("mid")]
        public int mid { get; set; }
    
        public int amount { get; set; }

        

        [ForeignKey("tid")]
        public virtual Theater Theater { get; set; }
    }
}