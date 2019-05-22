using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstBookingCollection
    {
        [TestMethod]
        public void InstanceOk()
        {//create an instance of the class
            clsBookingCollection TheBookings = new clsBookingCollection();
            // test the result
            Assert.IsNotNull(TheBookings);
        }


        //[TestMethod]
        //public void CountBooking()
        //{//create an instance of the class
        //    clsBookingCollection TheBookings = new clsBookingCollection();
        //    //create teast data
        //    Int32 SomeCount = 1;
        //    TheBookings.Count = SomeCount;
        //    // test the result
        //    Assert.AreEqual(TheBookings.Count, SomeCount);
        //}

        //[TestMethod]
        //public void CountAllBooking()
        //{//create an instance of the class
        //    clsBookingCollection TheBookings = new clsBookingCollection();
        //    //create a list to each booking (objects)
        //    List<clsBooking> BookingList = new List<clsBooking>();
        //    //add an item to the list
        //    //create testItem to add to the list
        //    clsBooking testItem = new clsBooking();
        //    //set its properties
        //    testItem.BookingId = 1;
        //    testItem.Electrical = "Saw";
        //    testItem.Household = "Chair";
        //    testItem.Rubbish = 2;

        //    testItem.CollectionDate = DateTime.Now.Date;
        //    testItem.TimeSlot = "9:00AM";

        //    //add the test item to the list
        //    BookingList.Add(testItem);

        //    TheBookings.AllBooking = BookingList;
        //    //test the result
        //    Assert.AreEqual(TheBookings.AllBooking, BookingList);

        //}


        //[TestMethod]
        //public void CountMatchList()
        //{//create an instance of the class
        //    clsBookingCollection TheBookings = new clsBookingCollection();
        //    //create a list to each booking (objects)
        //    List<clsBooking> BookingList = new List<clsBooking>();
        //    //add an item to the list
        //    //create testItem to add to the list
        //    clsBooking testItem = new clsBooking();
        //    //set its properties
        //    testItem.BookingId = 1;
        //    testItem.Electrical = "Saw";
        //    testItem.Household = "Chair";
        //    testItem.Rubbish = 2;

        //    testItem.CollectionDate = DateTime.Now.Date;
        //    testItem.TimeSlot = "9:00AM";

        //    //add the test item to the list
        //    BookingList.Add(testItem);

        //    TheBookings.AllBooking = BookingList;
        //    //test the result
        //    Assert.AreEqual(TheBookings.Count, BookingList.Count);

        //}
    }
}
