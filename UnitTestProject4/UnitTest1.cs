//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using ClassLibrary4;
namespace UnitTestProject4
{
    [TestFixture]
    public class SUT
    {

        [Test]
        [TestCase("user_11","secret@user11","Welcome user_11!!!")]
        [TestCase("user_22", "secret@user22", "Welcome user_22!!!")]
        [TestCase("user_11", "secret@user22", "Invalid user id/password")]
        public void UnitUnderTest_Scenario_ExpectedOutcome1(string id,string password,string message)
        {
            AccountsManager ac = new AccountsManager();
            string result = ac.ValidateUser(id,password);
            Assert.That(result, Is.EqualTo(message));
        }
    }
}
