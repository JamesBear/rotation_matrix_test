using System;
using LinearAlgebra.Matricies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LinearAlgebra;

namespace LinearAlgebra.UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DoubleMatrixTest and is intended
    ///to contain all DoubleMatrixTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoubleMatrixTest
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
        [TestMethod()]
        public void TransposedTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            DoubleMatrix expected = new Double[,] { { 1F, 2F },
                                                    { 2F, 3F },
                                                    { 3F, 4F } };
            Assert.AreEqual(expected, target.Transposed);
        }

        /// <summary>
        ///A test for Rows
        ///</summary>
        [TestMethod()]
        public void RowsTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.AreEqual(1, target.Rows[0].RowCount);
            Assert.AreEqual(3, target.Rows[0].ColumnCount);
            Assert.AreEqual(new DoubleMatrix(new Double[,] { { 1F, 2F, 3F } }), target.Rows[0]);
            Assert.AreEqual(new DoubleMatrix(new Double[,] { { 2F, 3F, 4F } }), target.Rows[1]);
        }

        /// <summary>
        ///A test for RowCount
        ///</summary>
        [TestMethod()]
        public void RowCountTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.AreEqual(2, target.RowCount);

            DoubleMatrix target2 = new DoubleMatrix(0);
            Assert.AreEqual(0, target2.RowCount);
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.AreEqual(1F, target[0, 0]);
            Assert.AreEqual(2F, target[1, 0]);
            Assert.AreEqual(3F, target[2, 0]);
            Assert.AreEqual(2F, target[0, 1]);
            Assert.AreEqual(3F, target[1, 1]);
            Assert.AreEqual(4F, target[2, 1]);
            target[0, 0] = 00F;
            target[1, 0] = 10F;
            target[2, 0] = 20F;
            target[0, 1] = 01F;
            target[1, 1] = 11F;
            target[2, 1] = 21F;
            Assert.AreEqual(00F, target[0, 0]);
            Assert.AreEqual(10F, target[1, 0]);
            Assert.AreEqual(20F, target[2, 0]);
            Assert.AreEqual(01F, target[0, 1]);
            Assert.AreEqual(11F, target[1, 1]);
            Assert.AreEqual(21F, target[2, 1]);
        }

        /// <summary>
        ///A test for IsVector
        ///</summary>
        [TestMethod()]
        public void IsVectorTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.IsFalse(target.IsVector);
            Assert.IsTrue(target.Rows[0].IsVector);
            Assert.IsTrue(target.Columns[0].IsVector);
        }

        /// <summary>
        ///A test for IsSquare
        ///</summary>
        [TestMethod()]
        public void IsSquareTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.IsFalse(target.IsSquare);
            Assert.IsTrue(target.SubMatrix(new Int32Range(0, 2), new Int32Range(0, 2)).IsSquare);
        }

        /// <summary>
        ///A test for IsScalar
        ///</summary>
        [TestMethod()]
        public void IsScalarTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.IsFalse(target.IsScalar);
            Assert.IsTrue(target.SubMatrix(new Int32Range(0, 1), new Int32Range(0, 1)).IsScalar);
        }

        /// <summary>
        ///A test for IsRowVector
        ///</summary>
        [TestMethod()]
        public void IsRowVectorTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.IsFalse(target.IsRowVector);
            Assert.IsTrue(target.Rows[0].IsRowVector);
            Assert.IsFalse(target.Columns[0].IsRowVector);
        }

        /// <summary>
        ///A test for IsMatrix
        ///</summary>
        [TestMethod()]
        public void IsMatrixTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.IsTrue(target.IsMatrix);
            Assert.IsFalse(target.Rows[0].IsMatrix);
            Assert.IsFalse(target.Columns[0].IsMatrix);
        }

        /// <summary>
        ///A test for IsEmpty
        ///</summary>
        [TestMethod()]
        public void IsEmptyTest()
        {
            DoubleMatrix target = new DoubleMatrix(5);
            Assert.IsFalse(target.IsEmpty);
            Assert.IsTrue(target.SubMatrix(new Int32Range(3, 3), new Int32Range(0, 3)).IsEmpty);
            Assert.IsTrue(target.SubMatrix(new Int32Range(0, 3), new Int32Range(3, 3)).IsEmpty);
            Assert.IsTrue(target.SubMatrix(new Int32Range(0, 0), new Int32Range(0, 0)).IsEmpty);
        }

        /// <summary>
        ///A test for IsColumnVector
        ///</summary>
        [TestMethod()]
        public void IsColumnVectorTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.IsFalse(target.IsColumnVector);
            Assert.IsFalse(target.Rows[0].IsColumnVector);
            Assert.IsTrue(target.Columns[0].IsColumnVector);
        }

        /// <summary>
        ///A test for Inverse
        ///</summary>
        [TestMethod()]
        public void InverseTest()
        {
            DoubleMatrix target = new Double[,] { {  4F,  2F,  2F  },
                                                  {  4F,  6F,  8F  },
                                                  { -2F,  2F,  4F  } };

            DoubleMatrix expected = new Double[,] { { 1.0F, -0.5F,  0.5F  },
                                                    {-4.0F,  2.5F, -3.0F  },
                                                    { 2.5F, -1.5F,  2.0F  } };


            DoubleMatrix actual = target.Inverse;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for InnerMatrix
        ///</summary>
        [TestMethod()]
        public void InnerMatrixTest()
        {
            MatrixBase<Double> inner = new Double[,] { { 1F, 2F } }; 
            DoubleMatrix target = new DoubleMatrix(inner); 
            Assert.AreEqual(inner, target.InnerMatrix);
        }


        /// <summary>
        ///A test for Copy
        ///</summary>
        [TestMethod()]
        public void CopyTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            DoubleMatrix actual = target.Copy;
            Assert.AreEqual(target, actual);
            Assert.AreNotEqual((object)target.DataSource, (object)actual.DataSource);

            DoubleMatrix actual2 = target.Rows[1].Copy;
            Assert.AreEqual(target.Rows[1], actual2);
            Assert.AreEqual(1, actual2.DataSource.ColumnCount);
        }

        /// <summary>
        ///A test for Columns
        ///</summary>
        [TestMethod()]
        public void ColumnsTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            DoubleMatrix.ColumnAccessor actual;
            actual = target.Columns;

            Assert.AreEqual(1, actual[0].ColumnCount);
            Assert.AreEqual(1, actual[1].ColumnCount);
            Assert.AreEqual(1, actual[2].ColumnCount);
            Assert.AreEqual(2, actual[0].RowCount);
            Assert.AreEqual(2, actual[1].RowCount);
            Assert.AreEqual(2, actual[2].RowCount);
            Assert.AreEqual(new DoubleMatrix(new Double[,] { { 1F }, { 2F } }), actual[0]);
            Assert.AreEqual(new DoubleMatrix(new Double[,] { { 2F }, { 3F } }), actual[1]);
            Assert.AreEqual(new DoubleMatrix(new Double[,] { { 3F }, { 4F } }), actual[2]);
        }

        /// <summary>
        ///A test for ColumnCount
        ///</summary>
        [TestMethod()]
        public void ColumnCountTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Assert.AreEqual(3, target.ColumnCount);

            DoubleMatrix target2 = new DoubleMatrix(0);
            Assert.AreEqual(0, target2.ColumnCount);
        }

        /// <summary>
        ///A test for Zero
        ///</summary>
        [TestMethod()]
        public void ZeroTest()
        {
            DoubleMatrix expected = new Double[,] { { 0, 0, 0 },
                                                    { 0, 0, 0 } };
            DoubleMatrix actual = DoubleMatrix.Zero(3, 2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SwapRows
        ///</summary>
        [TestMethod()]
        public void SwapRowsTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F },
                                                  { 3F, 4F, 5F } };
            DoubleMatrix original = new Double[,] { { 1F, 2F, 3F },
                                                    { 2F, 3F, 4F },
                                                    { 3F, 4F, 5F } };
            DoubleMatrix expected1 = new Double[,] { { 2F, 3F, 4F },
                                                     { 1F, 2F, 3F },
                                                     { 3F, 4F, 5F } };
            target.SwapRows(0, 1);
            Assert.AreEqual(expected1, target);
            target.SwapRows(1, 0);
            Assert.AreEqual(original, target);
        }

        /// <summary>
        ///A test for Subtraction
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void SubtractionTest1()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Double scalar = 3F;
            DoubleMatrix expected = new Double[,] { { -2F, -1F, 0F },
                                                    { -1F, 0F, 1F } };
            DoubleMatrix actual;
            actual = DoubleMatrix_Accessor.Subtraction(matrix, scalar);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Subtraction
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void SubtractionTest()
        {
            DoubleMatrix matrix1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix matrix2 = new Double[,] { { 4F, 3F, 2F },
                                                   { 3F, 2F, 1F } };
            DoubleMatrix expected = new Double[,] { { -3F, -1F, 1F },
                                                    { -1F,  1F, 3F } };

            DoubleMatrix actual = DoubleMatrix_Accessor.Subtraction(matrix1, matrix2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SubMatrix
        ///</summary>
        [TestMethod()]
        public void SubMatrixTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F },
                                                  { 3F, 4F, 5F },
                                                  { 4F, 5F, 6F } };
            DoubleMatrix expected1 = new Double[,] { { 1F, 2F },
                                                     { 2F, 3F } };
            DoubleMatrix expected2 = new Double[,] { { 4F, 5F },
                                                     { 5F, 6F } };
            DoubleMatrix actual1 = target.SubMatrix(new Int32Range(0, 2), new Int32Range(0, 2));
            DoubleMatrix actual2 = target.SubMatrix(new Int32Range(1, 3), new Int32Range(2, 4));
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        /// <summary>
        ///A test for GaussianElimination
        ///</summary>
        [TestMethod()]
        public void GaussianEliminationTest()
        {
            DoubleMatrix matrix = new Double[,] { {  2F,  1F, -1F,   8F },
                                                  { -3F, -1F,  2F, -11F },
                                                  { -2F,  1F,  2F,  -3F} };
            DoubleMatrix expected = new Double[,] { { 1F, 0F, 0F,  2F },
                                                    { 0F, 1F, 0F,  3F },
                                                    { 0F, 0F, 1F, -1F } };
            DoubleMatrix actual = DoubleMatrix.GaussianElimination(matrix);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Random
        ///</summary>
        [TestMethod()]
        public void RandomTest()
        {
            int columns = 4; 
            int rows = 5;             
            DoubleMatrix actual1 = DoubleMatrix.Random(columns, rows);
            DoubleMatrix actual2 = DoubleMatrix.Random(columns, rows);
            Assert.AreEqual(columns, actual1.ColumnCount);
            Assert.AreEqual(rows, actual1.RowCount);
            Assert.AreEqual(columns, actual2.ColumnCount);
            Assert.AreEqual(rows, actual2.RowCount);
            Assert.AreNotEqual(actual1, actual2);
        }

        /// <summary>
        ///A test for op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest1()
        {
            DoubleMatrix matrix1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix matrix2 = new Double[,] { { 2F, 3F, 4F },
                                                   { 3F, 4F, 5F } };
            DoubleMatrix expected = new Double[,] { { -1F, -1F, -1F },
                                                    { -1F, -1F, -1F } };

            DoubleMatrix actual = (matrix1 - matrix2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Double scalar = 3F;
            DoubleMatrix expected = new Double[,] { { -2F, -1F, 0F },
                                                    { -1F, 0F, 1F } };

            DoubleMatrix actual = (matrix - scalar);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest2()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            double scalar = 2F;
            DoubleMatrix expected = new Double[,] { { 2F, 4F, 6F },
                                                    { 4F, 6F, 8F } };
            DoubleMatrix actual = matrix * scalar;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest1()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            double scalar = 2F;
            DoubleMatrix expected = new Double[,] { { 2F, 4F, 6F },
                                                    { 4F, 6F, 8F } };
            DoubleMatrix actual = scalar * matrix;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest()
        {
            DoubleMatrix matrix1 = new Double[,] { { 1F, 0F, 2F },
                                                   {-1F, 3F, 1F } };
            DoubleMatrix matrix2 = new Double[,] { { 3F, 1F },
                                                   { 2F, 1F },
                                                   { 1F, 0F } };
            DoubleMatrix expected = new Double[,] { { 5F, 1F },
                                                    { 4F, 2F } };
            DoubleMatrix actual = matrix1 * matrix2;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for op_Inequality
        ///</summary>
        [TestMethod()]
        public void op_InequalityTest()
        {
            DoubleMatrix target1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix target2 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix target3 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 2F, 4F } };
            Assert.IsFalse(target1 != target1);
            Assert.IsFalse(target1 != target2);
            Assert.IsTrue(target1 != target3);
            Assert.IsTrue(target1 != target1.Transposed);
        }

        /// <summary>
        ///A test for op_Equality
        ///</summary>
        [TestMethod()]
        public void op_EqualityTest()
        {
            DoubleMatrix matrix1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix matrix2 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix matrix3 = new Double[,] { { 4F, 5F, 6F },
                                                   { 5F, 6F, 7F } };

            Assert.IsTrue(matrix1 == matrix2);
            Assert.IsTrue(matrix2 == matrix1);
            Assert.IsFalse(matrix1 == matrix3);
            Assert.IsFalse(matrix2 == matrix3);
            Assert.IsFalse(null == matrix2);
            Assert.IsFalse(matrix1 == null);
        }

        /// <summary>
        ///A test for op_Division
        ///</summary>
        [TestMethod()]
        public void op_DivisionTest()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            double scalar = 2F;
            DoubleMatrix expected = new Double[,] { { 0.5F, 1.0F, 1.5F },
                                                    { 1.0F, 1.5F, 2.0F } };
            DoubleMatrix actual = matrix / scalar;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest2()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            Double scalar = 3F;
            DoubleMatrix expected = new Double[,] { { 4F, 5F, 6F },
                                                    { 5F, 6F, 7F } };

            DoubleMatrix actual = (matrix + scalar);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest1()
        {
            DoubleMatrix matrix1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix matrix2 = new Double[,] { { 4F, 3F, 2F },
                                                   { 3F, 2F, 1F } };
            DoubleMatrix expected = new Double[,] { { 5F, 5F, 5F },
                                                    { 5F, 5F, 5F } };

            DoubleMatrix actual = (matrix1 + matrix2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            Double scalar = 3F;
            DoubleMatrix expected = new Double[,] { { 4F, 5F, 6F },
                                                    { 5F, 6F, 7F } };

            DoubleMatrix actual;
            actual = (scalar + matrix);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Normalize
        ///</summary>
        [TestMethod()]
        public void NormalizeTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            DoubleMatrix expected = new Double[,] { { 0.25F, 0.50F, 0.75F },
                                                    { 0.50F, 0.75F, 1.00F } };
            DoubleMatrix actual = target.Normalize();
            Assert.AreEqual(0F, actual.MinimumValue);
            Assert.AreEqual(1F, actual.MaximumValue);
        }

        /// <summary>
        ///A test for Negate
        ///</summary>
        [TestMethod()]
        public void NegateTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix expected = new Double[,] { { -1F, -2F, -3F },
                                                   { -2F, -3F, -4F } };
            DoubleMatrix actual;
            actual = target.Negate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Multiplication
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void MultiplicationTest1()
        {
            DoubleMatrix matrix1 = new Double[,] { { 1F, 0F, 2F },
                                                   {-1F, 3F, 1F } };
            DoubleMatrix matrix2 = new Double[,] { { 3F, 1F },
                                                   { 2F, 1F },
                                                   { 1F, 0F } };
            DoubleMatrix expected = new Double[,] { { 5F, 1F },
                                                    { 4F, 2F } };
            DoubleMatrix actual;
            actual = DoubleMatrix_Accessor.Multiplication(matrix1, matrix2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Multiplication
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void MultiplicationTest()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            double scalar = 2F;
            DoubleMatrix expected = new Double[,] { { 2F, 4F, 6F },
                                                    { 4F, 6F, 8F } };
            DoubleMatrix actual;
            actual = DoubleMatrix_Accessor.Multiplication(matrix, scalar);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for JoinVertical
        ///</summary>
        [TestMethod()]
        public void JoinVerticalTest1()
        {

            DoubleMatrix topMatrix = new Double[,] { { 1F, 2F, 3F },
                                                     { 2F, 3F, 4F } };
            DoubleMatrix bottomMatrix = new Double[,] { { 2F, 3F, 4F },
                                                        { 3F, 4F, 5F } };

            DoubleMatrix expected = new Double[,] { { 1F, 2F, 3F },
                                                    { 2F, 3F, 4F },
                                                    { 2F, 3F, 4F },
                                                    { 3F, 4F, 5F } };

            DoubleMatrix actual = DoubleMatrix.JoinVertical(topMatrix, bottomMatrix);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for JoinVertical
        ///</summary>
        [TestMethod()]
        public void JoinVerticalTest()
        {
            DoubleMatrix target1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix target2 = new Double[,] { { 2F, 3F, 4F },
                                                   { 3F, 4F, 5F } };
            DoubleMatrix target3 = new Double[,] { { 3F, 4F, 5F },
                                                   { 4F, 5F, 6F } };

            DoubleMatrix expected = new Double[,] { { 1F, 2F, 3F },
                                                    { 2F, 3F, 4F },
                                                    { 2F, 3F, 4F },
                                                    { 3F, 4F, 5F },
                                                    { 3F, 4F, 5F },
                                                    { 4F, 5F, 6F } };

            IEnumerable<DoubleMatrix> matricies = new List<DoubleMatrix>(new DoubleMatrix[] { target1, target2, target3 });
            DoubleMatrix actual = DoubleMatrix.JoinVertical(matricies);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for JoinHorizontal
        ///</summary>
        [TestMethod()]
        public void JoinHorizontalTest1()
        {
            DoubleMatrix leftMatrix = new Double[,] { { 1F, 2F, 3F },
                                                      { 2F, 3F, 4F } };
            DoubleMatrix rightMatrix = new Double[,] { { 2F, 3F, 4F },
                                                       { 3F, 4F, 5F } };

            DoubleMatrix expected = new Double[,] { { 1F, 2F, 3F, 2F, 3F, 4F },
                                                    { 2F, 3F, 4F, 3F, 4F, 5F } };

            DoubleMatrix actual = DoubleMatrix.JoinHorizontal(leftMatrix, rightMatrix);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for JoinHorizontal
        ///</summary>
        [TestMethod()]
        public void JoinHorizontalTest()
        {
            DoubleMatrix target1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix target2 = new Double[,] { { 2F, 3F, 4F },
                                                   { 3F, 4F, 5F } };
            DoubleMatrix target3 = new Double[,] { { 3F, 4F, 5F },
                                                   { 4F, 5F, 6F } };

            DoubleMatrix expected = new Double[,] { { 1F, 2F, 3F, 2F, 3F, 4F, 3F, 4F, 5F },
                                                    { 2F, 3F, 4F, 3F, 4F, 5F, 4F, 5F, 6F } };

            IEnumerable<DoubleMatrix> matricies = new List<DoubleMatrix>(new DoubleMatrix[] { target1, target2, target3 });
            DoubleMatrix actual = DoubleMatrix.JoinHorizontal(matricies);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsNullOrEmpty
        ///</summary>
        [TestMethod()]
        public void IsNullOrEmptyTest()
        {
            Assert.IsTrue(DoubleMatrix.IsNullOrEmpty(null));
            Assert.IsTrue(DoubleMatrix.IsNullOrEmpty(new DoubleMatrix(0)));
        }

        /// <summary>
        ///A test for IsNull
        ///</summary>
        [TestMethod()]
        public void IsNullTest()
        {
            Assert.IsTrue(DoubleMatrix.IsNull(null));
            Assert.IsFalse(DoubleMatrix.IsNull(new DoubleMatrix(0)));
        }

        /// <summary>
        ///A test for Invert
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void InvertTest()
        {
            DoubleMatrix target = new Double[,] { {  4F,  2F,  2F  },
                                                  {  4F,  6F,  8F  },
                                                  { -2F,  2F,  4F  } };

            DoubleMatrix expected = new Double[,] { { 1.0F, -0.5F,  0.5F  },
                                                    {-4.0F,  2.5F, -3.0F  },
                                                    { 2.5F, -1.5F,  2.0F  } };


            DoubleMatrix actual;
            actual = DoubleMatrix_Accessor.Invert(target);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Identity
        ///</summary>
        [TestMethod()]
        public void IdentityTest1()
        {
            DoubleMatrix expected = new double[,] { { 1, 0, 0, 0 },
                                                    { 0, 1, 0, 0 },
                                                    { 0, 0, 1, 0 },
                                                    { 0, 0, 0, 1 } };
            DoubleMatrix actual;
            actual = DoubleMatrix.Identity(4);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Identity
        ///</summary>
        [TestMethod()]
        public void IdentityTest()
        {
            DoubleMatrix expected1 = new double[,] { { 1, 0, 0, 0 },
                                                    { 0, 1, 0, 0 },
                                                    { 0, 0, 1, 0 } };
            Assert.AreEqual(expected1, DoubleMatrix.Identity(4, 3));

            DoubleMatrix expected2 = new double[,] { { 1, 0, 0 },
                                                     { 0, 1, 0 },
                                                     { 0, 0, 1 },
                                                     { 0, 0, 0 } };
            Assert.AreEqual(expected2, DoubleMatrix.Identity(3, 4));
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            DoubleMatrix target1 = new DoubleMatrix(); 
            DoubleMatrix target2 = new DoubleMatrix();
            Assert.AreNotEqual(target1.GetHashCode(), target2.GetHashCode());
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            DoubleMatrix target1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix target2 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix target3 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 2F, 4F } };
            Assert.IsTrue(target1.Equals(target1));
            Assert.IsTrue(target1.Equals(target2));
            Assert.IsFalse(target1.Equals(target3));
            Assert.IsFalse(target1.Equals(target1.Transposed));
        }

        /// <summary>
        ///A test for Equality
        ///</summary>
        [TestMethod()]
        public void EqualityTest()
        {
            DoubleMatrix target1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix target2 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix target3 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 2F, 4F } };
            Assert.IsTrue(DoubleMatrix.Equality(target1, target1));
            Assert.IsTrue(DoubleMatrix.Equality(target1, target2));
            Assert.IsFalse(DoubleMatrix.Equality(target1, target3));
            Assert.IsFalse(DoubleMatrix.Equality(target1, target1.Transposed));
        }

        /// <summary>
        ///A test for DotProduct
        ///</summary>
        [TestMethod()]
        public void DotProductTest1()
        {
            DoubleMatrix target1 = new Double[,] { { 1F, 2F, 3F } };
            DoubleMatrix target2 = new Double[,] { { 2F, 3F, 4F } };
            Double expected = 1F * 2F + 2F * 3F + 3F * 4F;
            Double actual = target1.DotProduct(target2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DotProduct
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void DotProductTest()
        {
            DoubleMatrix target1 = new Double[,] { { 1F, 2F, 3F } };
            DoubleMatrix target2 = new Double[,] { { 2F, 3F, 4F } };
            Double expected = 1F * 2F + 2F * 3F + 3F * 4F;
            Double actual = DoubleMatrix_Accessor.DotProduct(target1, target2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Division
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void DivisionTest()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F } };
            double scalar = 2F;
            DoubleMatrix expected = new Double[,] { { 0.5F, 1.0F, 1.5F },
                                                    { 1.0F, 1.5F, 2.0F } };
            DoubleMatrix actual = DoubleMatrix_Accessor.Division(matrix, scalar);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for CrossProduct
        ///</summary>
        [TestMethod()]
        public void CrossProductTest()
        {
            DoubleMatrix target = new DoubleMatrix(); // TODO: Initialize to an appropriate value
            DoubleMatrix b = null; // TODO: Initialize to an appropriate value
            DoubleMatrix expected = null; // TODO: Initialize to an appropriate value
            DoubleMatrix actual;
            actual = target.CrossProduct(b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CopyInto
        ///</summary>
        [TestMethod()]
        public void CopyIntoTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F  },
                                                  { 2F, 3F  } };
            DoubleMatrix targetMatrix = DoubleMatrix.Zero(4);
            DoubleMatrix expected1 = new Double[,] { { 1F, 2F, 0F, 0F },
                                                     { 2F, 3F, 0F, 0F },
                                                     { 0F, 0F, 0F, 0F },
                                                     { 0F, 0F, 0F, 0F } };

            target.CopyInto(targetMatrix, 0, 0);
            Assert.AreEqual(expected1, targetMatrix);

            DoubleMatrix expected2 = new Double[,] { { 1F, 2F, 0F, 0F },
                                                     { 2F, 3F, 0F, 0F },
                                                     { 0F, 0F, 1F, 2F },
                                                     { 0F, 0F, 2F, 3F } };

            target.CopyInto(targetMatrix, 2, 2);
            Assert.AreEqual(expected2, targetMatrix);
        }

        /// <summary>
        ///A test for CopyFrom
        ///</summary>
        [TestMethod()]
        public void CopyFromTest1()
        {
            DoubleMatrix sourceMatrix = new Double[,] { { 1F, 2F  },
                                                        { 2F, 3F  } };
            DoubleMatrix target = DoubleMatrix.Zero(2);
            target.CopyFrom(sourceMatrix);
            Assert.AreEqual(sourceMatrix, target);

            DoubleMatrix expected = new Double[,] { { 1F, 2F  },
                                                    { 1F, 2F  } };
            target.Rows[1].CopyFrom(target.Rows[0]);
            Assert.AreEqual(expected, target);
        }

        /// <summary>
        ///A test for CopyFrom
        ///</summary>
        [TestMethod()]
        public void CopyFromTest()
        {
            DoubleMatrix sourceMatrix = new Double[,] { { 1F, 2F  },
                                                        { 2F, 3F  } };
            DoubleMatrix target = DoubleMatrix.Zero(4,4);

            DoubleMatrix expected1 = new Double[,] { { 1F, 2F, 0F, 0F },
                                                     { 2F, 3F, 0F, 0F },
                                                     { 0F, 0F, 0F, 0F },
                                                     { 0F, 0F, 0F, 0F } };
            target.CopyFrom(sourceMatrix, 0, 0);
            Assert.AreEqual(expected1, target);

            DoubleMatrix expected2 = new Double[,] { { 1F, 2F, 0F, 0F },
                                                     { 2F, 3F, 0F, 0F },
                                                     { 0F, 0F, 1F, 2F },
                                                     { 0F, 0F, 2F, 3F } };
            target.CopyFrom(sourceMatrix, 2, 2);
            Assert.AreEqual(expected2, target);

            DoubleMatrix expected3 = new Double[,] { { 1F, 2F, 1F, 2F },
                                                     { 2F, 3F, 2F, 3F },
                                                     { 0F, 0F, 1F, 2F },
                                                     { 0F, 0F, 2F, 3F } };
            target.CopyFrom(sourceMatrix, 2, 0);
            Assert.AreEqual(expected3, target);
        }

        /// <summary>
        ///A test for Addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void AdditionTest1()
        {
            DoubleMatrix matrix = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            Double scalar = 3F;
            DoubleMatrix expected = new Double[,] { { 4F, 5F, 6F },
                                                    { 5F, 6F, 7F } };

            DoubleMatrix actual = DoubleMatrix_Accessor.Addition(matrix, scalar);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LinearAlgebra.dll")]
        public void AdditionTest()
        {
            DoubleMatrix matrix1 = new Double[,] { { 1F, 2F, 3F },
                                                   { 2F, 3F, 4F } };
            DoubleMatrix matrix2 = new Double[,] { { 4F, 3F, 2F },
                                                   { 3F, 2F, 1F } };
            DoubleMatrix expected = new Double[,] { { 5F, 5F, 5F },
                                                    { 5F, 5F, 5F } };
            
            DoubleMatrix actual = DoubleMatrix_Accessor.Addition(matrix1, matrix2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DoubleMatrix Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleMatrixConstructorTest5()
        {
            int columns = 3; 
            int rows = 4; 
            DoubleMatrix target = new DoubleMatrix(columns, rows);
            Assert.AreEqual(columns, target.ColumnCount);
            Assert.AreEqual(rows, target.RowCount);
        }

        /// <summary>
        ///A test for DoubleMatrix Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleMatrixConstructorTest4()
        {
            int rank = 3;
            DoubleMatrix target = new DoubleMatrix(rank);
            Assert.AreEqual(rank, target.ColumnCount);
            Assert.AreEqual(rank, target.RowCount);
        }

        /// <summary>
        ///A test for DoubleMatrix Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleMatrixConstructorTest3()
        {
            DoubleMatrix target = new DoubleMatrix();
            Assert.AreEqual(0, target.ColumnCount);
            Assert.AreEqual(0, target.RowCount);
            Assert.IsTrue(target.IsEmpty);
        }

        /// <summary>
        ///A test for DoubleMatrix Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleMatrixConstructorTest2()
        {
            DoubleMatrix target = new double[,] { { 1F, 2F, 3F }, 
                                                  { 2F, 3F, 4F } };
            DoubleMatrix actual = new DoubleMatrix(target);
            Assert.AreEqual(3, actual.ColumnCount);
            Assert.AreEqual(2, actual.RowCount);
            Assert.AreEqual(1F, actual[0, 0]);
            Assert.AreEqual(2F, actual[1, 0]);
            Assert.AreEqual(3F, actual[2, 0]);
            Assert.AreEqual(2F, actual[0, 1]);
            Assert.AreEqual(3F, actual[1, 1]);
            Assert.AreEqual(4F, actual[2, 1]);
        }

        /// <summary>
        ///A test for DoubleMatrix Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleMatrixConstructorTest1()
        {
            MatrixBase<double> matrix = new MatrixBase<double>(new double[,] { { 1F, 2F, 3F }, 
                                                                               { 2F, 3F, 4F } });
            DoubleMatrix target = new DoubleMatrix(matrix);
            Assert.AreEqual(3, target.ColumnCount);
            Assert.AreEqual(2, target.RowCount);
            Assert.AreEqual(1F, target[0, 0]);
            Assert.AreEqual(2F, target[1, 0]);
            Assert.AreEqual(3F, target[2, 0]);
            Assert.AreEqual(2F, target[0, 1]);
            Assert.AreEqual(3F, target[1, 1]);
            Assert.AreEqual(4F, target[2, 1]);
        }

        /// <summary>
        ///A test for DoubleMatrix Constructor
        ///</summary>
        [TestMethod()]
        public void DoubleMatrixConstructorTest()
        {
            double[,] doubleArray = new double[,] { { 1F, 2F, 3F }, 
                                                    { 2F, 3F, 4F } };
            DoubleMatrix target = new DoubleMatrix(doubleArray);
            Assert.AreEqual(3, target.ColumnCount);
            Assert.AreEqual(2, target.RowCount);
            Assert.AreEqual(1F, target[0, 0]);
            Assert.AreEqual(2F, target[1, 0]);
            Assert.AreEqual(3F, target[2, 0]);
            Assert.AreEqual(2F, target[0, 1]);
            Assert.AreEqual(3F, target[1, 1]);
            Assert.AreEqual(4F, target[2, 1]);
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            DoubleMatrix target = new DoubleMatrix(0); 
            string actual;
            actual = target.ToString();
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for MaximumValue
        ///</summary>
        [TestMethod()]
        public void MaximumValueTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F },
                                                  { 3F, 4F, 5F },
                                                  { 4F, 5F, 6F } };
            double actual = target.MaximumValue;
            Assert.AreEqual(6F, actual);
        }

        /// <summary>
        ///A test for MinimumValue
        ///</summary>
        [TestMethod()]
        public void MinimumValueTest()
        {
            DoubleMatrix target = new Double[,] { { 1F, 2F, 3F },
                                                  { 2F, 3F, 4F },
                                                  { 3F, 4F, 5F },
                                                  { 4F, 5F, 6F } };
            double actual = target.MinimumValue;
            Assert.AreEqual(1F, actual);
        }
    }
}
