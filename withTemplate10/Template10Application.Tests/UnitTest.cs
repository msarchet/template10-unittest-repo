using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework.AppContainer;

namespace Template10Application.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // This test will pass if you Run Test
        // This test is not debuggable due to the fact that the App.xaml.cs throws a Catostrophic Failure when starting this
        // test in debug mode
        [UITestMethod]
        public void TestMethod1()
        {
            var testControl = new TestControl();
            testControl.Text = "Yay";
            Microsoft.VisualStudio.TestPlatform.UnitTestFramework.Assert.AreEqual(testControl.Text, "Yay");
        }
    }
}
