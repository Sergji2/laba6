using System;

class Program
{
    static void Main()
    {
        // Example usage
        int num1 = 5, num2 = 10;
        Console.WriteLine($"Addition of numbers: {MathOperations.Add(num1, num2)}");

        double[] array1 = { 1.5, 2.5, 3.5 };
        double[] array2 = { 0.5, 1.5, 2.5 };
        Console.WriteLine($"Addition of arrays: [{string.Join(", ", MathOperations.Add(array1, array2))}]");

        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        Console.WriteLine($"Addition of matrices:");
        PrintMatrix(MathOperations.Add(matrix1, matrix2));

        Console.ReadLine(); // Pause to see the output
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
    }
}
