using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinearAlgebra.Matricies;

namespace LinearAlgebra.SampleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleMatrix a = new Double[,] { { 6F, 5F },
                                             { 2F, 3F } };
            DoubleMatrix b = new Double[,] { { 3F, 2F, 3F, 4F },
                                             { 2F, 3F, 4F, 5F } };

            Console.WriteLine("A = \n" + a);
            Console.WriteLine("B = \n" + b);
            Console.WriteLine("A x B = \n" + (a * b));
            Console.WriteLine("A.Rows[0] = \n" + a.Rows[0]);
            Console.WriteLine("A.Rows[1] = \n" + a.Rows[1]);
            Console.WriteLine("A.Column[1] = B.Column[0]");
            a.Columns[1] = b.Columns[0];
            Console.WriteLine("A = \n" + a);

            DoubleMatrix c = new Double[,] { {  4F,  2F,  2F  },
                                             {  4F,  6F,  8F  },
                                             { -2F,  2F,  4F  } };
            Console.WriteLine("C = \n" + c);
            Console.WriteLine("C.Inverse = \n" + c.Inverse);
            Console.WriteLine("C x C.Inverse = \n" + c * c.Inverse);

            double theta = -45 * Math.PI / 180;
            DoubleMatrix r2_1 = new Double[,] {
                {Math.Cos(theta), -Math.Sin(theta)},{Math.Sin(theta), Math.Cos(theta)}
            };
            DoubleMatrix v2_1 = new Double[,]{{1, 0}};
            var rotated = r2_1 * v2_1.Transposed;
            Console.WriteLine("theta={3},\n{0}\n*\n{1}\n={2}", r2_1, v2_1.Transposed, rotated, theta * 180 / Math.PI);

            double s = Math.Sqrt(2) / 2;
            DoubleMatrix zxy = new Double[,] { { 1, 0, s }, {0, s, s*s}, {-s*s, -s, s*s} };
            DoubleMatrix v3_1 = new Double[,] { { 1 }, { 0 }, { 1 } };
            rotated = zxy * v3_1;
            Console.WriteLine(rotated);

            Double deg2rad = Math.PI/180;
            DoubleMatrix x_rot = RotationMatrices.GetStandardRotationMatrix(0, 2, 0, -45*deg2rad, 0, 0);
            DoubleMatrix v101 = new DoubleMatrix(new Double[,] { {1},{0},{1} });
            rotated = x_rot * v101;
            Console.WriteLine(rotated);

            Console.ReadKey();
        }
    }
}
