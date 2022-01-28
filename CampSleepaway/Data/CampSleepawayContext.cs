using CampSleepaway.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampSleepaway.Data
{
    class CampSleepawayContext : DbContext
    {
        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Camper> Campers { get; set; }
        public DbSet<CamperInCabin> CampersInCabins { get; set; }
        public DbSet<Counselor> Counselors { get; set; }
        public DbSet<CounselorInCabin> CounselorsInCabins { get; set; }
        public DbSet<NextOfKin> NextOfKins { get; set; }
        public DbSet<CamperNextOfKin> CamperNextOfKins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-T2GL85N\SQLEXPRESS2017;Initial Catalog=CS_Daniel_Lindeberg;Integrated Security=True");
                //.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
                //    LogLevel.Information)
                //.EnableSensitiveDataLogging();
        }
    }
}
