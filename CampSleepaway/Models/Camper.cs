using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSleepaway.Models
{
    public class Camper
    {
        [Key]
        public int CamperId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNo { get; set; }
        public List<CamperNextOfKin> CamperNextOfKins { get; set; }
        public List<CamperInCabin> CamperInCabins { get; set; }
    }
}
