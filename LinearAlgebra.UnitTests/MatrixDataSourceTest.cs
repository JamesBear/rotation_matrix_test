using LinearAlgebra.Matricies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MatrixUnitTests
{


    /// <summary>
    ///This is a test class for MatrixDataSourceTest and is intended
    ///to contain all MatrixDataSourceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MatrixDataSourceTest
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
        ///A test for RowCount
        ///</summary>
        public void RowCountTestHelper<T>()
        {
            T[,] sampleSource = new T[6, 3];
            MatrixDataSource<T> target = new MatrixDataSource<T>(sampleSource);
            int expected = sampleSource.GetLength(0);
            int actual;
            actual = target.RowCount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RowCountTest()
        {
            RowCountTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        public void ItemTestHelper<T>()
        {
            T[,] sampleData = new T[6, 3];
            for (int i = 0; i < sampleData.GetLength(1); i++)
                for (int j = 0; j < sampleData.GetLength(0); j++)
                    sampleData[j, i] = default(T);

            MatrixDataSource<T> target = new MatrixDataSource<T>(sampleData);
            for (int column = 0; column < sampleData.GetLength(1); column++)
                for (int row = 0; row < sampleData.GetLength(0); row++)
                {
                    T expected = sampleData[row, column];
                    T actual = target[column, row];
                    Assert.AreEqual(expected, actual);
                    target[column, row] = expected;
                    actual = target[column, row];
                    Assert.AreEqual(expected, actual);
                }
        }

        [TestMethod()]
        public void ItemTest()
        {
            ItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DefaultView
        ///</summary>
        public void DefaultViewTestHelper<T>()
        {
            T[,] sampleData = new T[6, 3];
            for (int i = 0; i < sampleData.GetLength(0); i++)
                for (int j = 0; j < sampleData.GetLength(1); j++)
                    sampleData[i, j] = default(T);

            MatrixDataSource<T> target = new MatrixDataSource<T>(sampleData);
            MatrixBase<T> actual;
            actual = target.DefaultView;
            Assert.AreEqual(sampleData.GetLength(1), actual.ColumnCount);
            Assert.AreEqual(sampleData.GetLength(0), actual.RowCount);

            T[,] sampleData2 = new T[,] 
                { { default(T), default(T) },
                  { default(T), default(T) },
                  { default(T), default(T) },
                  { default(T), default(T) } };
            MatrixDataSource<T> target2 = new MatrixDataSource<T>(sampleData2);
            MatrixBase<T> actual2 = target2.DefaultView;
            Assert.AreEqual(2, actual2.ColumnCount);
            Assert.AreEqual(4, actual2.RowCount);
        }

        [TestMethod()]
        public void DefaultViewTest()
        {
            DefaultViewTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ColumnCount
        ///</summary>
        public void ColumnCountTestHelper<T>()
        {
            T[,] sampleSource = new T[6, 3];
            MatrixDataSource<T> target = new MatrixDataSource<T>(sampleSource);
            int expected = sampleSource.GetLength(1);
            int actual;
            actual = target.ColumnCount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ColumnCountTest()
        {
            ColumnCountTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixDataSource`1 Constructor
        ///</summary>
        public void MatrixDataSourceConstructorTest3Helper<T>()
        {
            int rank = 6;
            MatrixDataSource<T> target = new MatrixDataSource<T>(rank);

            for (int j = 0; j < target.RowCount; j++)
                for (int i = 0; i < target.ColumnCount; i++)
                    Assert.AreEqual(target[i, j], default(T));

            Assert.AreEqual(target.ColumnCount, rank);
            Assert.AreEqual(target.RowCount, rank);
        }

        [TestMethod()]
        public void MatrixDataSourceConstructorTest3()
        {
            MatrixDataSourceConstructorTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixDataSource`1 Constructor
        ///</summary>
        public void MatrixDataSourceConstructorTest2Helper<T>()
        {
            MatrixDataSource<T> target = new MatrixDataSource<T>();

            Assert.AreEqual(target.ColumnCount, 0);
            Assert.AreEqual(target.RowCount, 0);
        }

        [TestMethod()]
        public void MatrixDataSourceConstructorTest2()
        {
            MatrixDataSourceConstructorTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixDataSource`1 Constructor
        ///</summary>
        public void MatrixDataSourceConstructorTest1Helper<T>()
        {
            T[,] dataArray = new T[6, 3];
            for (int j = 0; j < dataArray.GetLength(1); j++)
                for (int i = 0; i < dataArray.GetLength(0); i++)
                    dataArray[i, j] = default(T);

            MatrixDataSource<T> target = new MatrixDataSource<T>(dataArray);
        }

        [TestMethod()]
        public void MatrixDataSourceConstructorTest1()
        {
            MatrixDataSourceConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixDataSource`1 Constructor
        ///</summary>
        public void MatrixDataSourceConstructorTestHelper<T>()
        {
            int columns = 6;
            int rows = 3;
            MatrixDataSource<T> target = new MatrixDataSource<T>(columns, rows);

            for (int j = 0; j < target.RowCount; j++)
                for (int i = 0; i < target.ColumnCount; i++)
                    Assert.AreEqual(target[i, j], default(T));
            Assert.AreEqual(target.ColumnCount, columns);
            Assert.AreEqual(target.RowCount, rows);
        }

        [TestMethod()]
        public void MatrixDataSourceConstructorTest()
        {
            MatrixDataSourceConstructorTestHelper<GenericParameterHelper>();
        }
    }
}
