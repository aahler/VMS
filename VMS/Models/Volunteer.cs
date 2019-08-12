using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace VMS.Models
{
    public class Volunteer
    {

        public int ID { get; set; }

        [Required, Display(Name = "Name")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        //[Required]
        //public List<string> Centers { get; set; }

        //[Required]
        //public List<string> Skills { get; set; }

        //[Required, DataType(DataType.Date)]
        //public List<DateTime> Availability { get; set; }

        [Required]
        public string Address { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        //[Required]
        //public List<string> Education { get; set; }

        //[Required]
        //public List<string> Licenses { get; set; }

        [Required]
        public string EmergencyName { get; set; }

        [Required, Phone]
        public string EmergencyPhone { get; set; }

        [Required, EmailAddress]
        public string EmergencyEmail { get; set; }

        [Required]
        public string EmergencyAddress { get; set; }

        [Required]
        public bool DLCopyExists { get; set; }

        [Required]
        public bool SSCopyExists { get; set; }

        [Required]
        public bool Approved { get; set; }
    }

    //public class VolunteerDbContext : DbContext
    //{
    //    public DbSet<Volunteer> Volunteers { get; set; }

    //    public VolunteerDbContext(DbContextOptions<VolunteerDbContext> options) 
    //        : base(options)
    //    { }
    //}
}
