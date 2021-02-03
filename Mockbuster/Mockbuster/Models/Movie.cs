using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mockbuster.Models
{
    public class Movie
    {
        [Requried]
        public int Id { get; set; }
        [Requried]
        [StringLength(255)]
        public string Name { get; set; }
        [Requried]
        [StringLength(124)]
        public string Genre { get; set; }
        [Requried]
        public DateTime ReleaseDate { get; set; }
        [Requried]
        public DateTime DateAdded { get; set; }
        [Requried]
        public byte NumberInStock { get; set; }
    }
}