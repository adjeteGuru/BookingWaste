using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace tstBookingWastes
{
    [TestClass]
    public class tstSecurity
    {
        [TestMethod]
        public void InstanceOk()
        {//create an instance of the class
            clsSecurity ASec = new clsSecurity();
            //test the result
            Assert.IsNotNull(ASec);
        }
    }
}
