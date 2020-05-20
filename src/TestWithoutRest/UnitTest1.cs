using System;
using TravelAgency.DAl;
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
            store.FillTestData(10);       
            Assert.AreEqual("0", store.Agencies[0].Portions[0].Trip.Location);
        }
    }
}
