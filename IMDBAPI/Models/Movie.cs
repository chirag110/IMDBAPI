using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBAPI.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public IList<Actor> Actors { get; set; }
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }

        //Many TO One REL WITH PRODUCER
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
        //public string ProducerName { get; set; }

        //Many to Many Rel between Actor and Movie
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
