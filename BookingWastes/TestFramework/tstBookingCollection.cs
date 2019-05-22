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
            clsBookingCollection ABooking = new clsBookingCollection();
            // test the result
            Assert.IsNotNull(ABooking);
        }


        [TestMethod]
        public void CountBooking()
        {//create an instance of the class
            clsBookingCollection AllBooking = new clsBookingCollection();
            //create teast data
            int SomeCount = 1;
            AllBooking.Count = SomeCount;
            // test the result
            Assert.AreEqual(AllBooking.Count, SomeCount);
        }
    }
}
