using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSleepaway.Models
{
    public class Cabin
    {
        [Key]
        public int CabinId { get; set; }
        public string Name { get; set; }
    }
}
