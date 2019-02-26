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
            Console.WriteLine("Изменяю dev");
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
