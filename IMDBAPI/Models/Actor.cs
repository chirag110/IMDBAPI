﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBAPI.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
