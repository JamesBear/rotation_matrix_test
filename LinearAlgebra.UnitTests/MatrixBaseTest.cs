using LinearAlgebra.Matricies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearAlgebra;
using System;
using System.Collections.Generic;

namespace LinearAlgebra.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for MatrixBaseTest and is intended
    ///to contain all MatrixBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MatrixBaseTest
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
        ///A test for Transposed
        ///</summary>
        public void TransposedTestHelper<T>()
        {
            MatrixBase<Double> target = new Double[,] { { 1F, 2F, 3F },
                                                        { 2F, 3F, 4F } };
            MatrixBase<Double> expected = new Double[,] { { 1F, 2F },
                                                          { 2F, 3F },
                                                          { 3F, 4F } };
            MatrixBase<Double> actual = target.Transposed;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TransposedTest()
        {
            TransposedTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Rows
        ///</summary>
        public void RowsTestHelper<T>()
        {
            MatrixBase<Double> target = new Double[,] { { 11F, 12F, 13F, 14F },
                                                        { 21F, 22F, 23F, 24F },
                                                        { 31F, 32F, 33F, 34F } };
            int actual = target.RowCount;
            Assert.AreEqual(3, actual);

            MatrixBase<Double> target2 = target.SubMatrix(new Int32Range(0, 2), new Int32Range(0, 2));
            int actual2 = target.RowCount;
            Assert.AreEqual(2, actual);
        }

        [TestMethod()]
        public void RowsTest()
        {
            RowsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for RowCount
        ///</summary>
        public void RowCountTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.RowCount;
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            int column = 0; // TODO: Initialize to an appropriate value
            int row = 0; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            target[column, row] = expected;
            actual = target[column, row];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ItemTest()
        {
            ItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsVector
        ///</summary>
        public void IsVectorTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsVector;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsVectorTest()
        {
            IsVectorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsSquare
        ///</summary>
        public void IsSquareTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsSquare;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsSquareTest()
        {
            IsSquareTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsScalar
        ///</summary>
        public void IsScalarTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsScalar;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsScalarTest()
        {
            IsScalarTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsRowVector
        ///</summary>
        public void IsRowVectorTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsRowVector;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsRowVectorTest()
        {
            IsRowVectorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsMatrix
        ///</summary>
        public void IsMatrixTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsMatrix;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsMatrixTest()
        {
            IsMatrixTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsEmpty
        ///</summary>
        public void IsEmptyTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsEmptyTest()
        {
            IsEmptyTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsColumnVector
        ///</summary>
        public void IsColumnVectorTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsColumnVector;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsColumnVectorTest()
        {
            IsColumnVectorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DataSource
        ///</summary>
        public void DataSourceTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            MatrixDataSource<T> actual;
            actual = target.DataSource;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DataSourceTest()
        {
            DataSourceTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DataRowRange
        ///</summary>
        public void DataRowRangeTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            Int32Range actual;
            actual = target.DataRowRange;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DataRowRangeTest()
        {
            DataRowRangeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DataColumnRange
        ///</summary>
        public void DataColumnRangeTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            Int32Range actual;
            actual = target.DataColumnRange;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DataColumnRangeTest()
        {
            DataColumnRangeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Columns
        ///</summary>
        public void ColumnsTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            MatrixBase<T>.ColumnAccessor<T> actual;
            actual = target.Columns;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ColumnsTest()
        {
            ColumnsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ColumnCount
        ///</summary>
        public void ColumnCountTestHelper<T>()
        {
            MatrixBase<Double> target = new Double[,] { { 11F, 12F, 13F, 14F },
                                                        { 21F, 22F, 23F, 24F },
                                                        { 31F, 32F, 33F, 34F } };
            int actual = target.ColumnCount;
            Assert.AreEqual(4, actual);

            MatrixBase<Double> target2 = target.SubMatrix(new Int32Range(0, 2), new Int32Range(0, 2));
            int actual2 = target.ColumnCount;
            Assert.AreEqual(2, actual);
        }

        [TestMethod()]
        public void ColumnCountTest()
        {
            ColumnCountTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Transpose
        ///</summary>
        public void TransposeTestHelper<T>()
        {
            MatrixBase<Double> target = new Double[,] { { 1F, 2F, 3F },
                                                        { 2F, 3F, 4F } };
            MatrixBase<Double> expected = new Double[,] { { 1F, 2F },
                                                          { 2F, 3F },
                                                          { 3F, 4F } };
            MatrixBase<Double> actual = MatrixBase<Double>.Transpose(target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TransposeTest()
        {
            TransposeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        public void ToStringTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); 
            string actual = target.ToString();
            Assert.IsNotNull(actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            ToStringTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SwapRows
        ///</summary>
        public void SwapRowsTest1Helper<T>()
        {
            MatrixBase<Double> target = new Double[,] { { 11F, 12F, 13F, 14F },
                                                        { 21F, 22F, 23F, 24F },
                                                        { 31F, 32F, 33F, 34F } };
            MatrixBase<Double> expected = new Double[,] { { 21F, 22F, 23F, 24F },
                                                          { 11F, 12F, 13F, 14F },
                                                          { 31F, 32F, 33F, 34F } };
            int row1 = 0;
            int row2 = 1;
            MatrixBase<Double>.SwapRows(target, row1, row2);
            Assert.AreEqual(expected, target);
        }

        [TestMethod()]
        public void SwapRowsTest1()
        {
            SwapRowsTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SwapRows
        ///</summary>
        public void SwapRowsTestHelper<T>()
        {
            MatrixBase<Double> target = new Double[,] { { 11F, 12F, 13F, 14F },
                                                        { 21F, 22F, 23F, 24F },
                                                        { 31F, 32F, 33F, 34F } };
            MatrixBase<Double> expected = new Double[,] { { 21F, 22F, 23F, 24F },
                                                          { 11F, 12F, 13F, 14F },
                                                          { 31F, 32F, 33F, 34F } };
            int row1 = 0; 
            int row2 = 1; 
            target.SwapRows(row1, row2);
            Assert.AreEqual(expected, target);
        }

        [TestMethod()]
        public void SwapRowsTest()
        {
            SwapRowsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SubMatrix
        ///</summary>
        public void SubMatrixTest1Helper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            Int32Range columnRange = null; // TODO: Initialize to an appropriate value
            Int32Range rowRange = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = target.SubMatrix(columnRange, rowRange);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SubMatrixTest1()
        {
            SubMatrixTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SubMatrix
        ///</summary>
        public void SubMatrixTestHelper<T>()
        {
            MatrixBase<T> view = null; // TODO: Initialize to an appropriate value
            Int32Range columnRange = null; // TODO: Initialize to an appropriate value
            Int32Range rowRange = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.SubMatrix(view, columnRange, rowRange);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SubMatrixTest()
        {
            SubMatrixTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for op_Inequality
        ///</summary>
        public void op_InequalityTestHelper<T>()
        {
            MatrixBase<T> matrix1 = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> matrix2 = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = (matrix1 != matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_InequalityTest()
        {
            op_InequalityTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for op_Implicit
        ///</summary>
        public void op_ImplicitTestHelper<T>()
        {
            T[,] dataArray = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = dataArray;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_ImplicitTest()
        {
            op_ImplicitTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for op_Equality
        ///</summary>
        public void op_EqualityTestHelper<T>()
        {
            MatrixBase<T> matrix1 = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> matrix2 = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = (matrix1 == matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_EqualityTest()
        {
            op_EqualityTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for JoinVertical
        ///</summary>
        public void JoinVerticalTest1Helper<T>()
        {
            MatrixBase<T> topMatrix = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> bottomMatrix = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.JoinVertical(topMatrix, bottomMatrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void JoinVerticalTest1()
        {
            JoinVerticalTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for JoinVertical
        ///</summary>
        public void JoinVerticalTestHelper<T>()
        {
            IEnumerable<MatrixBase<T>> matricies = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.JoinVertical(matricies);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void JoinVerticalTest()
        {
            JoinVerticalTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for JoinHorizontal
        ///</summary>
        public void JoinHorizontalTest1Helper<T>()
        {
            MatrixBase<T> leftMatrix = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> rightMatrix = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.JoinHorizontal(leftMatrix, rightMatrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void JoinHorizontalTest1()
        {
            JoinHorizontalTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for JoinHorizontal
        ///</summary>
        public void JoinHorizontalTestHelper<T>()
        {
            IEnumerable<MatrixBase<T>> matricies = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.JoinHorizontal(matricies);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void JoinHorizontalTest()
        {
            JoinHorizontalTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsNullOrEmpty
        ///</summary>
        public void IsNullOrEmptyTestHelper<T>()
        {
            MatrixBase<T> matrix = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = MatrixBase<T>.IsNullOrEmpty(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsNullOrEmptyTest()
        {
            IsNullOrEmptyTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsNull
        ///</summary>
        public void IsNullTestHelper<T>()
        {
            MatrixBase<T> matrix = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = MatrixBase<T>.IsNull(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsNullTest()
        {
            IsNullTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        public void GetHashCodeTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            GetHashCodeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        public void EqualsTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void EqualsTest()
        {
            EqualsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Equality
        ///</summary>
        public void EqualityTestHelper<T>()
        {
            MatrixBase<T> matrix1 = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> matrix2 = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = MatrixBase<T>.Equality(matrix1, matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void EqualityTest()
        {
            EqualityTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ElementWiseOperation
        ///</summary>
        public void ElementWiseOperationTest3Helper<T>()
        {
            MatrixBase<T> matrix = null; // TODO: Initialize to an appropriate value
            MatrixBase<T>.ElementPositionalUnaryOperationDelegate operation = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.ElementWiseOperation(matrix, operation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ElementWiseOperationTest3()
        {
            ElementWiseOperationTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ElementWiseOperation
        ///</summary>
        public void ElementWiseOperationTest2Helper<T>()
        {
            MatrixBase<T> matrix = null; // TODO: Initialize to an appropriate value
            T scalar = default(T); // TODO: Initialize to an appropriate value
            MatrixBase<T>.ElementBinaryOperationDelegate operation = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.ElementWiseOperation(matrix, scalar, operation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ElementWiseOperationTest2()
        {
            ElementWiseOperationTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ElementWiseOperation
        ///</summary>
        public void ElementWiseOperationTest1Helper<T>()
        {
            MatrixBase<T> matrix1 = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> matrix2 = null; // TODO: Initialize to an appropriate value
            MatrixBase<T>.ElementBinaryOperationDelegate operation = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.ElementWiseOperation(matrix1, matrix2, operation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ElementWiseOperationTest1()
        {
            ElementWiseOperationTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ElementWiseOperation
        ///</summary>
        public void ElementWiseOperationTestHelper<T>()
        {
            MatrixBase<T> matrix = null; // TODO: Initialize to an appropriate value
            MatrixBase<T>.ElementUnaryOperationDelegate operation = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.ElementWiseOperation(matrix, operation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ElementWiseOperationTest()
        {
            ElementWiseOperationTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ElementWiseCopy
        ///</summary>
        public void ElementWiseCopyTestHelper<T>()
        {
            MatrixBase<T> source = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> target = null; // TODO: Initialize to an appropriate value
            int targetColumnOffset = 0; // TODO: Initialize to an appropriate value
            int targetRowOffset = 0; // TODO: Initialize to an appropriate value
            MatrixBase<T>.ElementWiseCopy(source, target, targetColumnOffset, targetRowOffset);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void ElementWiseCopyTest()
        {
            ElementWiseCopyTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DimensionsMatch
        ///</summary>
        public void DimensionsMatchTestHelper<T>()
        {
            MatrixBase<T> matrix1 = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> matrix2 = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = MatrixBase<T>.DimensionsMatch(matrix1, matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DimensionsMatchTest()
        {
            DimensionsMatchTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Default
        ///</summary>
        public void DefaultTestHelper<T>()
        {
            int columns = 0; // TODO: Initialize to an appropriate value
            int rows = 0; // TODO: Initialize to an appropriate value
            MatrixBase<T> expected = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> actual;
            actual = MatrixBase<T>.Default(columns, rows);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DefaultTest()
        {
            DefaultTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CopyInto
        ///</summary>
        public void CopyIntoTest1Helper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            MatrixBase<T> targetMatrix = null; // TODO: Initialize to an appropriate value
            int targetColumnOffset = 0; // TODO: Initialize to an appropriate value
            int targetRowOffset = 0; // TODO: Initialize to an appropriate value
            target.CopyInto(targetMatrix, targetColumnOffset, targetRowOffset);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void CopyIntoTest1()
        {
            CopyIntoTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CopyInto
        ///</summary>
        public void CopyIntoTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            MatrixBase<T> targetMatrix = null; // TODO: Initialize to an appropriate value
            target.CopyInto(targetMatrix);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void CopyIntoTest()
        {
            CopyIntoTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CopyFrom
        ///</summary>
        public void CopyFromTest1Helper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            MatrixBase<T> sourceMatrix = null; // TODO: Initialize to an appropriate value
            int targetColumnOffset = 0; // TODO: Initialize to an appropriate value
            int targetRowOffset = 0; // TODO: Initialize to an appropriate value
            target.CopyFrom(sourceMatrix, targetColumnOffset, targetRowOffset);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void CopyFromTest1()
        {
            CopyFromTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CopyFrom
        ///</summary>
        public void CopyFromTestHelper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>(); // TODO: Initialize to an appropriate value
            MatrixBase<T> sourceMatrix = null; // TODO: Initialize to an appropriate value
            target.CopyFrom(sourceMatrix);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void CopyFromTest()
        {
            CopyFromTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        public void CloneTestHelper<T>()
        {
            MatrixBase<Double> target = new Double[,] { { 11F, 12F, 13F, 14F },
                                                        { 21F, 22F, 23F, 24F },
                                                        { 31F, 32F, 33F, 34F } };
            MatrixBase<Double> expected = new Double[,] { { 11F, 12F, 13F, 14F },
                                                          { 21F, 22F, 23F, 24F },
                                                          { 31F, 32F, 33F, 34F } };
            MatrixBase<Double> actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.AreNotEqual((object)expected.DataSource, (object)actual.DataSource);
        }

        [TestMethod()]
        public void CloneTest()
        {
            CloneTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixBase`1 Constructor
        ///</summary>
        public void MatrixBaseConstructorTest6Helper<T>()
        {
            int columns = 0; // TODO: Initialize to an appropriate value
            int rows = 0; // TODO: Initialize to an appropriate value
            MatrixBase<T> target = new MatrixBase<T>(columns, rows);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MatrixBaseConstructorTest6()
        {
            MatrixBaseConstructorTest6Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixBase`1 Constructor
        ///</summary>
        public void MatrixBaseConstructorTest5Helper<T>()
        {
            int rank = 0; // TODO: Initialize to an appropriate value
            MatrixBase<T> target = new MatrixBase<T>(rank);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MatrixBaseConstructorTest5()
        {
            MatrixBaseConstructorTest5Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixBase`1 Constructor
        ///</summary>
        public void MatrixBaseConstructorTest4Helper<T>()
        {
            MatrixBase<T> target = new MatrixBase<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MatrixBaseConstructorTest4()
        {
            MatrixBaseConstructorTest4Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixBase`1 Constructor
        ///</summary>
        public void MatrixBaseConstructorTest3Helper<T>()
        {
            T[,] elementArray = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> target = new MatrixBase<T>(elementArray);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MatrixBaseConstructorTest3()
        {
            MatrixBaseConstructorTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixBase`1 Constructor
        ///</summary>
        public void MatrixBaseConstructorTest2Helper<T>()
        {
            MatrixDataSource<T> matrixData = null; // TODO: Initialize to an appropriate value
            Int32Range columnRange = null; // TODO: Initialize to an appropriate value
            Int32Range rowRange = null; // TODO: Initialize to an appropriate value
            MatrixBase_Accessor<T> target = new MatrixBase_Accessor<T>(matrixData, columnRange, rowRange);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void MatrixBaseConstructorTest2()
        {
            MatrixBaseConstructorTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixBase`1 Constructor
        ///</summary>
        public void MatrixBaseConstructorTest1Helper<T>()
        {
            MatrixDataSource<T> matrixData = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> target = new MatrixBase<T>(matrixData);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MatrixBaseConstructorTest1()
        {
            MatrixBaseConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MatrixBase`1 Constructor
        ///</summary>
        public void MatrixBaseConstructorTestHelper<T>()
        {
            MatrixBase<T> matrix = null; // TODO: Initialize to an appropriate value
            MatrixBase<T> target = new MatrixBase<T>(matrix);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void MatrixBaseConstructorTest()
        {
            MatrixBaseConstructorTestHelper<GenericParameterHelper>();
        }
    }
}
