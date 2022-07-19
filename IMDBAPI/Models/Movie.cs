using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBAPI.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public List<Actor> Actors { get; set; }
        public Producer Producer { get; set; }
    }
}
