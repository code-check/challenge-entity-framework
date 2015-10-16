using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EntityFrameworkChallenge.Models
{
    [Table("challenges")]
    public class Challenge
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }

        [Required]
        public string Name { get; set; }
        //BEGIN_CHALLENGE
        public virtual ICollection<Participant> Participants { get; set; }
        //END_CHALLENGE
    }
}
