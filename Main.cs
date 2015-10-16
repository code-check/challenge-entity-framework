using EntityFrameworkChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkChallenge
{
    public class Main
    {
        public int CountUsers(string filter)
        {
            //BEGIN_CHALLENGE
            using (var context = new ChallengeContext())
                return context.Users.Count(x => x.Name.Contains(filter) || x.Email.Contains(filter));
            //END_CHALLENGE
            throw new NotImplementedException();
        }

        public User FindUserByZipcode(string zipcode)
        {
            //BEGIN_CHALLENGE
            using (var context = new ChallengeContext())
                return context.Users.FirstOrDefault(x => x.Information.ZipCode == zipcode);
            //END_CHALLENGE
            throw new NotImplementedException();
        }

        public User[] ListParticipantsByCreatorFirstname(string name)
        {
            //BEGIN_CHALLENGE
            using (var context = new ChallengeContext())
                return context.Challenges
                    .Where(c => c.Creator.Information.FirstName.Equals(name))
                    .SelectMany(c => c.Participants.Select(p => p.User))
                    .ToArray();
            //END_CHALLENGE
            throw new NotImplementedException();
        }
    }
}
