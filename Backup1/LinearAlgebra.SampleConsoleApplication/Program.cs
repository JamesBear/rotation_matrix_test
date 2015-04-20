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


            Console.ReadKey();
        }
    }
}
