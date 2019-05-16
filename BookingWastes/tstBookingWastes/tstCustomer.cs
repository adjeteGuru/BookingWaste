using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace tstBookingWastes
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {//create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test result
            Assert.IsNotNull(ACustomer);
        }
    }
}
