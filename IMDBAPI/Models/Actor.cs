using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBAPI.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public IList<Movie> Movies { get; set; }
        public string ActorName { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
