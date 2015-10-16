using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EntityFrameworkChallenge.Models
{
    [Table("participants")]
    public class Participant
    {
        //BEGIN_CHALLENGE
        [Key, Column(Order = 0)]
        public int UserId { get; set; }

        [Key, Column(Order = 1)]
        public int ChallengeId { get; set; }

        public virtual User User { get; set; }

        public virtual Challenge Challenge { get; set; }
        //END_CHALLENGE
    }
}
