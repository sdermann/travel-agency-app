using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelAgency.Models;

namespace TestWithoutRest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
     
        public void FillData()
        {
            VisitEasy store = new VisitEasy();
           
            Assert.AreEqual("0", store.Agencies[0].Portions[0].Trip.Location);
        }
    }
}
