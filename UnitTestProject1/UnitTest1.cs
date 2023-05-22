using System;
using Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var demo = new DemoAPI ();
             var response = demo.GetResponse();
            Assert.AreEqual(1,response.Participants);
            Assert.AreEqual("social", response.Type);
            Assert.AreEqual("Write a note of appreciation to someone", response.Activity);
            Assert.AreEqual(0, response.Price);
            Assert.AreEqual("\"1770521\"", response.Key);
            Assert.AreEqual(0,response.Accessibility);


        }
    }
}
