using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace FilialauthentifizierungTest
{
    [TestClass]
    public class Authenticator
    {
        [TestMethod]
        public void TestHash()
        {
            Filialauthentifizierung.Authenticator authenticator = new Filialauthentifizierung.Authenticator();
            byte[] hash = authenticator.Hash("coffee");
            string expected ="37290D74AC4D186E3A8E5785D259D2EC04FAC91AE28092E7620EC8BC99E830AA";
            Assert.AreEqual(expected, BitConverter.ToString(hash).Replace("-",""));
        }
        [TestMethod]
        public void TestHashToString()
        {
            Filialauthentifizierung.Authenticator authenticator = new Filialauthentifizierung.Authenticator();
            byte[] hash = authenticator.Hash("coffee");
            string hashToString = authenticator.HashToString(hash);
            string expected2 = "37290D74";
            Assert.AreEqual(expected2, hashToString);
        }
    } 
}

