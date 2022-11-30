using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBapp.Models
{
    public partial class Producers
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public string Bio { get; set; }
        public DateTime? Dob { get; set; }
        public string Company { get; set; }
        public string Gender { get; set; }
    }
}
