using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSleepaway.Models
{
    public class NextOfKin
    {
        [Key]
        public int NextOfKinId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public List<CamperNextOfKin> CamperNextOfKins { get; set; }
    }
}
