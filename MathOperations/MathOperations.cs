class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int[] Add(int[] a, int[] b)
    {
        if (a.Length != b.Length)
            throw new ArgumentException("Arrays must have the same length.");

        int[] result = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Add(a[i], b[i]);
        }
        return result;
    }

    public static double[] Add(double[] a, double[] b)
    {
        if (a.Length != b.Length)
            throw new ArgumentException("Arrays must have the same length.");

        double[] result = new double[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = Add(a[i], b[i]);
        }
        return result;
    }

    public static int[,] Add(int[,] a, int[,] b)
    {
        if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
            throw new ArgumentException("Matrices must have the same dimensions.");

        int[,] result = new int[a.GetLength(0), a.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                result[i, j] = Add(a[i, j], b[i, j]);
            }
        }
        return result;
    }

    public static double[,] Add(double[,] a, double[,] b)
    {
        if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
            throw new ArgumentException("Matrices must have the same dimensions.");

        double[,] result = new double[a.GetLength(0), a.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                result[i, j] = Add(a[i, j], b[i, j]);
            }
        }
        return result;
    }
}