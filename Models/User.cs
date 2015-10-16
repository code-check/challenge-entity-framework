using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EntityFrameworkChallenge.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
        //BEGIN_CHALLENGE
        public virtual UserInformation Information { get; set; }

        public virtual ICollection<Participant> Participants { get; set; }
        //END_CHALLENGE
    }
}
