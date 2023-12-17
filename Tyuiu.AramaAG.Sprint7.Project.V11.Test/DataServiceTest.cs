using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint7.Project.V11.Lib;

namespace Tyuiu.AramaAG.Sprint7.Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethodCountStaff()
        {
            DataService dataService = new DataService();
            string path = @"C:\Users\Lenovo\Downloads\ДанныеФорматcsv.csv";
            int fileExists = dataService.CountStaff(path);
            int wait = 10;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void MaxExperienceStaff()
        {
            DataService dataService = new DataService();
            string path = @"C:\Users\Lenovo\Downloads\ДанныеФорматcsv.csv";
            int fileExists = dataService.MaxExperienceStaff(path);
            int wait = 17;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
