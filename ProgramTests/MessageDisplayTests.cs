using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld;

namespace ProgramTests
{
    [TestClass]
    public class MessageDisplayTests
    {
        [TestMethod]
        public void GoodMorningMessageOnlyTheMorning()
        {
            // GIVEN 
            FakeTimeGiver fake = new FakeTimeGiver(DayOfWeek.Saturday, 15);

            // WHEN
            Message target = new Message(fake, new UserGiver());

            // THEN
            string result = target.CustomMessage;
            Assert.AreEqual("Bon week-end bapti", result);
            
        }

        [TestMethod]
        public void GoodUserNameDisplayed()
        {
            // GIVEN
            FakeUserGiver fake = new FakeUserGiver();
            fake.fakeUser("Bernard");

            // WHEN
            Message target = new Message(new TimeGiver(), fake);

            //THEN
            string result = target.userName;
            Assert.AreEqual("Bernard", result);

        }
    }
}
