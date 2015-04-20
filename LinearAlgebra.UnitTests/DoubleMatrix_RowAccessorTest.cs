using LinearAlgebra.Matricies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace LinearAlgebra.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DoubleMatrix_RowAccessorTest and is intended
    ///to contain all DoubleMatrix_RowAccessorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoubleMatrix_RowAccessorTest
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
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            DoubleMatrix matrix = null; // TODO: Initialize to an appropriate value
            DoubleMatrix.RowAccessor target = new DoubleMatrix.RowAccessor(matrix); // TODO: Initialize to an appropriate value
            int rowIndex = 0; // TODO: Initialize to an appropriate value
            DoubleMatrix expected = null; // TODO: Initialize to an appropriate value
            DoubleMatrix actual;
            target[rowIndex] = expected;
            actual = target[rowIndex];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for System.Collections.IEnumerable.GetEnumerator
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void GetEnumeratorTest1()
        {
            DoubleMatrix matrix = null; // TODO: Initialize to an appropriate value
            IEnumerable target = new DoubleMatrix.RowAccessor(matrix); // TODO: Initialize to an appropriate value
            IEnumerator expected = null; // TODO: Initialize to an appropriate value
            IEnumerator actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        [TestMethod()]
        public void GetEnumeratorTest()
        {
            DoubleMatrix matrix = null; // TODO: Initialize to an appropriate value
            DoubleMatrix.RowAccessor target = new DoubleMatrix.RowAccessor(matrix); // TODO: Initialize to an appropriate value
            IEnumerator<DoubleMatrix> expected = null; // TODO: Initialize to an appropriate value
            IEnumerator<DoubleMatrix> actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AsEnumerable
        ///</summary>
        [TestMethod()]
        public void AsEnumerableTest()
        {
            DoubleMatrix matrix = null; // TODO: Initialize to an appropriate value
            DoubleMatrix.RowAccessor target = new DoubleMatrix.RowAccessor(matrix); // TODO: Initialize to an appropriate value
            IEnumerable<DoubleMatrix> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<DoubleMatrix> actual;
            actual = target.AsEnumerable();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RowAccessor Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleMatrix_RowAccessorConstructorTest()
        {
            DoubleMatrix matrix = null; // TODO: Initialize to an appropriate value
            DoubleMatrix.RowAccessor target = new DoubleMatrix.RowAccessor(matrix);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
