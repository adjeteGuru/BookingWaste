using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace tstBookingWastes
{
    [TestClass]
    public class tstBookingCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class 
            clsBookingCollection ACollection = new clsBookingCollection();
            //test the result
            Assert.IsNotNull(ACollection);
        }
    }
}
