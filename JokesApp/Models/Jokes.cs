using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JokesApp.Models
{
    public class Jokes
    {
        public int Id { get; set; }
        
        [Required]
        public string JokeQuestion { get; set; }
        
        [Required]
        public string JokeAnswer { get; set; }

        public Jokes()
        {

        }
    }
}
