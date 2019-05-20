using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstBooking
    {
        [TestMethod]
        public void InstanceOk()
        
        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            // test result
            Assert.IsNotNull(ABooking);

        }

        //test the property
        [TestMethod]
        public void TestElectrical()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            string Electrical = "Saw";
            //assign the property to the object of the class
            ABooking.Electrical = Electrical;
            // test the result
            Assert.AreEqual(Electrical, ABooking.Electrical);

        }

        //test the property
        [TestMethod]
        public void TestHousehold()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            string Household = "Chair";
            //assign the property to the object of the class
            ABooking.Household = Household;
            // test the result
            Assert.AreEqual(Household, ABooking.Household);

        }

        //test the property
        [TestMethod]
        public void TestRubbish()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            Int32 Rubbish = 2;
            //assign the property to the object of the class
            ABooking.Rubbish = Rubbish;
            // test the result
            Assert.AreEqual(Rubbish, ABooking.Rubbish);

        }

        //test the property
        [TestMethod]
        public void TestCollectionDate()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            DateTime CollectionDate = DateTime.Now.Date;
            //assign the property to the object of the class
            ABooking.CollectionDate = CollectionDate;
            // test the result
            Assert.AreEqual(CollectionDate, ABooking.CollectionDate);

        }

        //test the property
        [TestMethod]
        public void TestTimeSlot()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            string TimeSlot = "10am";
            //assign the property to the object of the class
            ABooking.TimeSlot = TimeSlot;
            // test the result
            Assert.AreEqual(TimeSlot, ABooking.TimeSlot);

        }

        //test validation property for anay new data d
        [TestMethod]
        public void TestValidation()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create object to hold the result info
            string Error = "";
            //create a test data for the test
            string Electrical = "Saw";
            string Household = "Chair";
            Int32 Rubbish = 2;
            DateTime CollectionDate = DateTime.Now.Date;
            string TimeSlot = "10am";
            Error = ABooking.Valid(Electrical, Household, Rubbish, CollectionDate, TimeSlot);
            Assert.AreEqual(Error, "");

        }
    }
}
