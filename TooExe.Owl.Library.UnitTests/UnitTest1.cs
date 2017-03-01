using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TooExe.Owl.Library.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = "This is my example.";
            var expected = new List<string> { "This", "is", "my","example." } ;
           
           var actual = input.ToWordList() as List<string>;
           
                Assert.AreEqual(expected.Count, actual.Count);
                for (var i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(expected[i], actual[i]);
                }
            
        }
    }
}
