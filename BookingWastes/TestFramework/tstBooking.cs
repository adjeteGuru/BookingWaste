﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstBooking
    {//variables declared for test
    //    string Electrical = "Saw";
    //    string Household = "Chair";
    //    int Rubbish = 2;
    //    string CollectionDate = DateTime.Now.Date.ToString();
    //    string TimeSlot = "9:00AM";

        [TestMethod]
        public void InstanceOk()
        
        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            // test result
            Assert.IsNotNull(ABooking);

        }

        [TestMethod]
        public void TestBookingId()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create test data to test the property
            int BookingId = 1;
            //assign the property to the object of the class
            ABooking.BookingId = BookingId;
            // test the result
            Assert.AreEqual(BookingId, ABooking.BookingId);

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

        //test the property dr
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
           // DateTime CollectionDate = Convert.ToString("30/05/2019");
            //assign the property to the object of the class
            ABooking.CollectionDate = Convert.ToDateTime(CollectionDate);
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

        //test validation property for anay new datas
        [TestMethod]
        public void TestValidation()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();
            //create object to hold the result info
            string Error = "";
            //create a test data for the test
            string Electrical = "Saw";
            string Household = "Chair";
            Int32 Rubbish = 5;
            string CollectionDate = DateTime.Now.Date.ToString("30/05/2019");
            string TimeSlot = "10am";
            Error = ABooking.Valid(Electrical, Household, Rubbish, CollectionDate, TimeSlot);
            Assert.AreEqual(Error, "");

        }

        //test Find method any new datas
        [TestMethod]
        public void TestFindMethodOk()

        {// create an instance of the class
            clsBooking ABooking = new clsBooking();

            //create object to hold the result info
            Boolean Found = false;

            //create a testdata to against the object
            int BookingId = 2;

            //invoke the method
           Found = ABooking.Find(BookingId);

            //test the result
            Assert.IsTrue(Found);

        }

        ////test Find method any new data
        //[TestMethod]
        //public void TestBookingNoFound()

        //{// create an instance of the class
        //    clsBooking ABooking = new clsBooking();

        //    //create object to hold the result info
        //    Boolean Found = false;
        //    //Boolean variable to record if data is OK
        //    Boolean OK = true;
        //    //create a testdata to against the object
        //    int BookingId = 4;

        //    //invoke the method
        //    Found = ABooking.Find(BookingId);
        //    if (ABooking.BookingId != 4)
        //    {
        //        OK = false;
        //    }

        //    //test the result
        //    Assert.IsTrue(OK);

        //}
    }
}
