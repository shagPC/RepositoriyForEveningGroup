using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Изменяю development");
        }
        [TestMethod]
        public void Sum_2and3()
        {
            int two = 2;
            int three = 3;
            int sum = two + three;
            Assert.AreEqual(5,sum);
        }
        [TestMethod]
        public void ProfessionalTest()
        {
            Console.WriteLine("Bla Bla Bla");
        }

        [TestMethod]
        public void DastanTest()
        {
            Console.WriteLine("Bla?");
        }
    }
}
