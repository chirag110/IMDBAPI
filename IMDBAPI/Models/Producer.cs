using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBAPI.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        //One to Many Rel between Producer and Movie
        public IList<Movie> Movies { get; set; }
    }
}
