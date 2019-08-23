using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalShelter.Models
{
    [Table("dogs")]
    public class Dog
    {
        [Key]
        public int DogId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

    }
}