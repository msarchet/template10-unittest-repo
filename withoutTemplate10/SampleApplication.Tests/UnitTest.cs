using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework.AppContainer;

namespace SampleApplication.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // This works as expected for Running and Debugging a test
        [UITestMethod]
        public void TestMethod1()
        {
            var testControl = new TestControl();
            testControl.Text = "Yay";
            Microsoft.VisualStudio.TestPlatform.UnitTestFramework.Assert.AreEqual(testControl.Text, "Yay");
        }
    }
}
