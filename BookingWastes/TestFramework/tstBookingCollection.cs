using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

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
    }
}
