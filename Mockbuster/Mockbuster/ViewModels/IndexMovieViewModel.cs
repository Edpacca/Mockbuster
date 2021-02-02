using Mockbuster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mockbuster.ViewModels
{
    public class IndexMovieViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}