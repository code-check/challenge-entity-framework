using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//BEGIN_CHALLENGE
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
//END_CHALLENGE

namespace EntityFrameworkChallenge.Models
{
    //BEGIN_CHALLENGE
    [Table("userinformation")]
    //END_CHALLENGE
    public class UserInformation
    {
        //BEGIN_CHALLENGE
        [Key, ForeignKey("User")]
        public int UserId {get;set;}

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string ZipCode { get; set; }

        public virtual User User { get; set; }
        //END_CHALLENGE
    }
}
