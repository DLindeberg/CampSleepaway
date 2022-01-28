using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSleepaway.Models
{
    public class Counselor
    {
        [Key]
        public int CounselorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<CounselorInCabin> counselorInCabins { get; set; }
    }
}
