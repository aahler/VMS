using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VMS.Models
{
    public class VMSContext : DbContext
    {
        public VMSContext (DbContextOptions<VMSContext> options)
            : base(options)
        {
        }

        public DbSet<VMS.Models.Volunteer> Volunteer { get; set; }
    }
}
