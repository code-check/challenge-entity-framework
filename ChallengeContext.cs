using EntityFrameworkChallenge.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EntityFrameworkChallenge
{
    public class ChallengeContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserInformation> UserInformation { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
