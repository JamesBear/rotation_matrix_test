using LinearAlgebra.Matricies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace LinearAlgebra.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for MatrixBase_ColumnAccessorTest and is intended
    ///to contain all MatrixBase_ColumnAccessorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MatrixBase_ColumnAccessorTest
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
        public void ItemTestHelper<T, T1>()
        {
            MatrixBase<T> dataView = null; // TODO: Initialize to an appropriate value
            MatrixBase<T>.ColumnAccessor<T> target = new MatrixBase<T>.ColumnAccessor<T>(dataView); // TODO: Initialize to an appropriate value
            int columnIndex = 0; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            target[columnIndex] = expected;
            actual = target[columnIndex];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ItemTest()
        {
            ItemTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for System.Collections.IEnumerable.GetEnumerator
        ///</summary>
        public void GetEnumeratorTest1Helper<T, T1>()
        {
            MatrixBase<T> dataView = null; // TODO: Initialize to an appropriate value
            IEnumerable target = new MatrixBase<T>.ColumnAccessor<T>(dataView); // TODO: Initialize to an appropriate value
            IEnumerator expected = null; // TODO: Initialize to an appropriate value
            IEnumerator actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void GetEnumeratorTest1()
        {
            GetEnumeratorTest1Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        public void GetEnumeratorTestHelper<T, T1>()
        {
            MatrixBase<T> dataView = null; // TODO: Initialize to an appropriate value
            MatrixBase<T>.ColumnAccessor<T> target = new MatrixBase<T>.ColumnAccessor<T>(dataView); // TODO: Initialize to an appropriate value
            IEnumerator<MatrixBase<T>> expected = null; // TODO: Initialize to an appropriate value
            IEnumerator<MatrixBase<T>> actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetEnumeratorTest()
        {
            GetEnumeratorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for AsEnumerable
        ///</summary>
        public void AsEnumerableTestHelper<T, T1>()
        {
            MatrixBase<T> dataView = null; // TODO: Initialize to an appropriate value
            MatrixBase<T>.ColumnAccessor<T> target = new MatrixBase<T>.ColumnAccessor<T>(dataView); // TODO: Initialize to an appropriate value
            IEnumerable<MatrixBase<T>> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<MatrixBase<T>> actual;
            actual = target.AsEnumerable();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void AsEnumerableTest()
        {
            AsEnumerableTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ColumnAccessor`1 Constructor
        ///</summary>
        public void MatrixBase_ColumnAccessorConstructorTestHelper<T, T1>()
        {
            MatrixBase<T> dataView = null; // TODO: Initialize to an appropriate value
            MatrixBase<T>.ColumnAccessor<T> target = new MatrixBase<T>.ColumnAccessor<T>(dataView);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MatrixBase_ColumnAccessorConstructorTest()
        {
            MatrixBase_ColumnAccessorConstructorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }
    }
}
