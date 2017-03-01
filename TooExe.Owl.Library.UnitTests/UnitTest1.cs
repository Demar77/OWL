using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TooExe.Owl.Library.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new Class1().ExampleMethod();

            Assert.AreEqual("Ok",result);
        }
    }
}
