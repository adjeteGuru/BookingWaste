using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace tstBookingWastes
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {//create an instance of the class
            clsCustomerCollection ACustCollection = new clsCustomerCollection();
            //test the result
            Assert.IsNotNull(ACustCollection);
        }
    }
}
