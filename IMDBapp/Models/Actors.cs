using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBapp.Models
{
    public partial class Actors
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string Bio { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
    }
}
