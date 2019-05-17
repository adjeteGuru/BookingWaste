using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BWClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {//create an Instance of the class
            clsCustomer ACustomer = new clsCustomer();
            // test the result
            
            Assert.IsNotNull(ACustomer);
        }
    }
}
