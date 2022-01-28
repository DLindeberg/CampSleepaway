using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSleepaway.Models
{
    public class CounselorInCabin
    {
        [Key]
        public int CounselorInCabinId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [ForeignKey("Counselor")]
        public int CounselorId { get; set; }
        public Counselor Counselor { get; set; }
        [ForeignKey("Cabin")]
        public int CabinId { get; set; }
        public Cabin Cabin { get; set; }
    }
}
