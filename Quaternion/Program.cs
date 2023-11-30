using System;

class Program
{
    static void Main()
    {
        Quaternion q1 = new Quaternion(1, 2, 3, 4);
        Quaternion q2 = new Quaternion(5, 6, 7, 8);

        Quaternion addition = q1 + q2;
        Quaternion subtraction = q1 - q2;
        Quaternion multiplication = q1 * q2;

        double norm = q1.Norm();
        Quaternion conjugate = q1.Conjugate();
        Quaternion inverse = q1.Inverse();

        bool areEqual = q1 == q2;
        bool areNotEqual = q1 != q2;

        double[,] rotationMatrix = q1.ToRotationMatrix();

        Quaternion fromMatrix = Quaternion.FromRotationMatrix(rotationMatrix);

        Console.WriteLine("Quaternion 1: " + q1.W + " " + q1.X + " " + q1.Y + " " + q1.Z);
        Console.WriteLine("Quaternion 2: " + q2.W + " " + q2.X + " " + q2.Y + " " + q2.Z);
        Console.WriteLine("Addition: " + addition.W + " " + addition.X + " " + addition.Y + " " + addition.Z);
        Console.WriteLine("Subtraction: " + subtraction.W + " " + subtraction.X + " " + subtraction.Y + " " + subtraction.Z);
        Console.WriteLine("Multiplication: " + multiplication.W + " " + multiplication.X + " " + multiplication.Y + " " + multiplication.Z);
        Console.WriteLine("Norm: " + norm);
        Console.WriteLine("Conjugate: " + conjugate.W + " " + conjugate.X + " " + conjugate.Y + " " + conjugate.Z);
        Console.WriteLine("Inverse: " + inverse.W + " " + inverse.X + " " + inverse.Y + " " + inverse.Z);
        Console.WriteLine("Equality check: " + areEqual);
        Console.WriteLine("Inequality check: " + areNotEqual);
        Console.WriteLine("Rotation Matrix:");
        PrintMatrix(rotationMatrix);
        Console.WriteLine("Quaternion from Rotation Matrix: " + fromMatrix.W + " " + fromMatrix.X + " " + fromMatrix.Y + " " + fromMatrix.Z);

    }

    static void PrintMatrix(double[,] matrix)
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
}
