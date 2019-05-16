using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace tstBookingWastes
{
    [TestClass]
    public class tstBooking
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //test result
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        public void TestElectrical()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            string testData = "Saw";
            //create to assign the property
            ABooking.Electrical = testData;
            //test result
            Assert.AreEqual(testData, ABooking.Electrical);
        }

        [TestMethod]
        public void TestHouseHold()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            string testData = "Chair";
            //create to assign the property
            ABooking.Household = testData;
            //test result
            Assert.AreEqual(testData, ABooking.Household);
        }

        [TestMethod]
        public void TestRubbish()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            Int32 testData = 2;
            //create to assign the property
            ABooking.Rubbish = testData;
            //test result
            Assert.AreEqual(testData, ABooking.Rubbish);
        }

        [TestMethod]
        public void TestCollectionDate()
        {
            //create instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            DateTime testData = DateTime.Now.Date;
            //create to assign the property
            ABooking.CollectionDate = testData;
            //test result
            Assert.AreEqual(testData, ABooking.CollectionDate);
        }
    }
}
