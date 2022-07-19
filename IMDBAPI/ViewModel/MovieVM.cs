using IMDBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBAPI.ViewModel
{
    public class MovieVM
    {
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string ProducerName { get; set; }
        //public Producer Producer { get; set; }
        public List<string> ActorNames { get; set; }
    }

    //Single Responsibility to handle POST Requests
    public class MovieVMAdd : MovieVM
    {
        public List<Actor> Actors { get; set; }
        public Producer Producer { get; set; }
    }
    
}
