using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppSortedName;
namespace AppSortedTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesUnsortedList()
        {
            var s = new sortLib();        
            Assert.AreEqual(s.unsortedList(),s.listUnsort);
        }

        [TestMethod]
        public void TesGetListName()
        {
            var s = new sortLib();
            var data = s.unsortedList();        
            Assert.AreEqual(s.GetLastName(data), s.listGetName);
        }

        [TestMethod]
        public void TesSortedList()
        {
            var s = new sortLib();
            var dataFull = s.unsortedList();
            var dataLast = s.GetLastName(dataFull);
            Assert.AreEqual(s.CreateSortedList(dataLast,dataFull), s.listSortedList);
        }
    }
}
