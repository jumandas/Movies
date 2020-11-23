using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MoviesDay2.Models
{
    [Table("tbltheatre")]
    public class Theater
    {
        [Key]
        public int tid { get; set; }
        public string tname { get; set; }
        public string location { get; set; }
    }
}