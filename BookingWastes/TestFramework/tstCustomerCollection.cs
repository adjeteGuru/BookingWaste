using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {//create an instance od the class
            clsCustomerCollection CustCollection = new clsCustomerCollection();
            // test result
            Assert.IsNotNull(CustCollection);
        }
    }
}
