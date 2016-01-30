using CountWords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for DoCount
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CountWords.exe")]
        public void DoCountTest1()
        {
            string[] args = null; 
            var actual = Program_Accessor.DoCount(args);
            Assert.AreEqual(null, actual);
        }

        /// <summary>
        ///A test for DoCount
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CountWords.exe")]
        public void DoCountTest2()
        {
            var args = new string[0]; 
            var actual = Program_Accessor.DoCount(args);
            Assert.AreEqual(null, actual);
        }


        /// <summary>
        ///A test for DoCount
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CountWords.exe")]
        public void DoCountTest3()
        {
            var args = new string[1] { "This is a statement, and so is this." };
           // var expected = new Dictionary<string, int> 
           // { { "this", 2 }, { "is", 2 }, { "a", 1 }, { "statement", 1 }, { "and", 1 }, { "so", 1 } }; 
            var actual = Program_Accessor.DoCount(args);
            const int expectedCount = 6;
            Assert.AreEqual(expectedCount, ((Dictionary<string, int>)actual).Count);
            Assert.IsTrue(((Dictionary<string, int>)actual).ContainsKey("this") && ((Dictionary<string, int>)actual)["this"] == 2);
            Assert.IsTrue(((Dictionary<string, int>)actual).ContainsKey("is") && ((Dictionary<string, int>)actual)["is"] == 2);
            Assert.IsTrue(((Dictionary<string, int>)actual).ContainsKey("a") && ((Dictionary<string, int>)actual)["a"] == 1);
            Assert.IsTrue(((Dictionary<string, int>)actual).ContainsKey("statement") && ((Dictionary<string, int>)actual)["statement"] == 1);
            Assert.IsTrue(((Dictionary<string, int>)actual).ContainsKey("and") && ((Dictionary<string, int>)actual)["and"] == 1);
            Assert.IsTrue(((Dictionary<string, int>)actual).ContainsKey("so") && ((Dictionary<string, int>)actual)["so"] == 1);
        }
    }
}
