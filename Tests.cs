using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkChallenge
{
    [TestFixture]
    public class Tests : Main
    {
        [Test]
        public void CountUsersTest()
        {
            Assert.AreEqual(1, CountUsers("root"));
            Assert.AreEqual(4, CountUsers("test"));
            Assert.AreEqual(2, CountUsers("none"));
            Assert.AreEqual(0, CountUsers("abc"));
        }

        [Test]
        public void FindUserByZipcodeTest()
        {
            Assert.AreEqual("root", FindUserByZipcode("012345").Name);
            Assert.AreEqual("Test1", FindUserByZipcode("123456").Name);
        }

        [Test]
        public void ListParticipantsByCreatorFirstnameTest() 
        {
            var results = ListParticipantsByCreatorFirstname("Admin")
                .Select(x => x.Name)
                .OrderBy(x => x)
                .ToArray();
            Assert.AreEqual(3, results.Count());
            Assert.AreEqual("Challenger1", results[0]);
            Assert.AreEqual("Challenger2", results[1]);
            Assert.AreEqual("root", results[2]);
        }
    }
}
