namespace MatrixOpTest
{
    [TestClass]
    public class MatrOpTest
    {
        [TestMethod]
        public void TestMatrSum()
        {
            double[,] a = new double[10, 10];
            double[,] b = new double[10, 10];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 1;
                }
            }

            MatrixOp matrixOp = new MatrixOp(a, b);
            double[,] c = matrixOp.Sum();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {

                    a[i, j] -= b[i, j];
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Assert.AreEqual(a[i, j], c[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestMatrSubtr() 
        {
            double[,] a = new double[10, 10];
            double[,] b = new double[10, 10];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 1;
                }
            }

            MatrixOp matrixOp = new MatrixOp(a, b);
            double[,] c = matrixOp.Subtract();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {

                    a[i, j] += b[i, j];
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Assert.AreEqual(a[i, j], c[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestMatrMult() 
        {
            double[,] a = new double[,] 
              { { 2, 1, 4}, 
                { 7, 3, 7} };
            double[,] b = new double[,] 
              { { 1, 3}, 
                { 10, 2}, 
                { 8, 4} };

            MatrixOp matrixOp = new MatrixOp(a, b);
            var c = matrixOp.Multiple();

            double[,] d = new double[,] 
              { { 0, 0 },
                { 0, 0 } };

            for (int i = 0; i < c.GetLength(0); i++) 
            {
                for (int j = 0; j < c.GetLength(1); j++) 
                {
                    Assert.AreEqual(d[i, j], c[i, j]);
                }
            }
        }
    }
}