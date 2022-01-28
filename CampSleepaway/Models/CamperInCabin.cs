using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSleepaway.Models
{
    public class CamperInCabin
    {
        [Key]
        public int CamperInCabinId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [ForeignKey("Camper")]
        public int CamperId { get; set; }
        public Camper Camper { get; set; }
        [ForeignKey("Cabin")]
        public int CabinId { get; set; }
        public Cabin Cabin { get; set; }
    }
}
