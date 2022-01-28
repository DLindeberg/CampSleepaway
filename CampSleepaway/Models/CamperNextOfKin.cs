using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSleepaway.Models
{
    public class CamperNextOfKin
    {
        [Key]
        public int CamperNextOfKinId { get; set; }
        [ForeignKey("Camper")]
        public int CamperId { get; set; }
        public Camper Camper { get; set; }
        [ForeignKey("NextOfKin")]
        public int NextOfKinId { get; set; }
        public NextOfKin NextOfKin { get; set; }
    }
}
