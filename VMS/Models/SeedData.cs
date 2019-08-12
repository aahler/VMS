using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace VMS.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VMSContext(
                serviceProvider.GetRequiredService<DbContextOptions<VMSContext>>()))
            {
                if (context.Volunteer.Any())
                {
                    return;
                }

                context.Volunteer.AddRange(
                    new Volunteer
                    {
                        FirstName = "Ted",
                        LastName = "Bundy",
                        Username = "SlayerLover",
                        Password = "hacksaw",
                        Address = "123 Killa Lane",
                        PhoneNumber = "1234567890",
                        Email = "tedbundyisinnoccent@live.com",
                        EmergencyName = "Charles Manson",
                        EmergencyPhone = "911",
                        EmergencyEmail = "charlesmansonrules@hotmail.com",
                        EmergencyAddress = "123 Prison Graveyard Row",
                        DLCopyExists = true,
                        SSCopyExists = true,
                        Approved = false
                    },
                    new Volunteer
                    {
                        FirstName = "Austin",
                        LastName = "Ahler",
                        Username = "TedBundyLover",
                        Password = "bundy4ever",
                        Address = "124 Killa Lane",
                        PhoneNumber = "1234567890",
                        Email = "tedbundyisinnoccent1@live.com",
                        EmergencyName = "Ted Bundy",
                        EmergencyPhone = "911",
                        EmergencyEmail = "charlesmansonstillrules@hotmail.com",
                        EmergencyAddress = "123 Killa Lane",
                        DLCopyExists = true,
                        SSCopyExists = true,
                        Approved = false
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
