using IMDBAPI.Data;
using IMDBAPI.Models;
using IMDBAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMDBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMDBApiContext _dbContext;
    
        public MoviesController(IMDBApiContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<MovieVM> Get()
        {
            var movies = _dbContext.Movies.Select(movie => new MovieVM()
            {
                MovieName = movie.MovieName,
                ReleaseDate = movie.ReleaseDate,
                ActorNames = movie.Actor_Movies.Select(x => x.Actor.ActorName).ToList(),
                ProducerName = movie.Producer.ProducerName
            }).ToList() ;
            return movies;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public MovieVM Get(int id)
        {
            var movie = _dbContext.Movies.Where(x => x.MovieId == id).Select(movie => new MovieVM()
            {
                MovieName = movie.MovieName,
                ReleaseDate = movie.ReleaseDate,
                ActorNames = movie.Actor_Movies.Select(x => x.Actor.ActorName).ToList(),
                ProducerName = movie.Producer.ProducerName
            }).FirstOrDefault();
            return movie;
            
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] MovieVMAdd movie)
        {
            var newMovie = new Movie()
            {
                MovieName = movie.MovieName,
                ReleaseDate = movie.ReleaseDate,
                Producer = movie.Producer,
                Actors = movie.Actors
            };
            _dbContext.Movies.Add(newMovie);
            _dbContext.SaveChanges();
            //To Keep Record of all actors in Schema Table
            var movieId = newMovie.MovieId;
            foreach (var item in newMovie.Actors)
            {
                var actorMovie = new Actor_Movie()
                {
                    ActorId = item.ActorId,
                    MovieId = movieId
                };
                _dbContext.Actors_Movies.Add(actorMovie);
                _dbContext.SaveChanges();
            }
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MovieVMAdd movie)
        {
            var _movie = _dbContext.Movies.FirstOrDefault(x => x.MovieId == id);
            if(_movie != null)
            {
                _movie.MovieName = movie.MovieName;
                _movie.ReleaseDate = movie.ReleaseDate;
                _movie.Actors = movie.Actors;
                _movie.Producer = movie.Producer;
                _dbContext.SaveChanges();
            }
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
