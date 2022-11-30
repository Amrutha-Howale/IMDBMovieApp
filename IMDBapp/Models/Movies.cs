using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBapp.Models
{
    public partial class Movies
    {
        public Movies()
        {
            Actors = new Actors();
            Producers = new Producers();
        }

        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Plot { get; set; }
        public DateTime? DateOfRelease { get; set; }
        public string Poster { get; set; }
        public int? ActorId { get; set; }
        public int? ProducerId { get; set; }

        public virtual Actors Actors { get; set; }
        public virtual Producers Producers { get; set; }
    }
}
