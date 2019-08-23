using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private AnimalShelterContext _db = new AnimalShelterContext();

        // GET api/dogs
        [HttpGet]
        public ActionResult<IEnumerable<Dog>> Get()
        {
            return _db.Dogs.ToList();
        }

        // GET api/dogs/5
        [HttpGet("{id}")]
        public ActionResult<Dog> GetThisDog(int id)
        {
            var thisDog = _db.Dogs.FirstOrDefault(x => x.DogId == id);
            return thisDog;
        } 

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] Dog dog)
        {
            _db.Dogs.Add(dog);
            _db.SaveChanges();
        }

        // PUT api/dogs/5
        public void Put(int id, [FromBody] Dog dog)
        {
            dog.DogId = id;
            _db.Entry(dog).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/dogs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dogToDelete = _db.Dogs.FirstOrDefault(x => x.DogId == id);
            _db.Dogs.Remove(dogToDelete);
            _db.SaveChanges();
        }
    }
}