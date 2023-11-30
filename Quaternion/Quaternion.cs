class Quaternion
{
    public double W { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Quaternion(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    public static Quaternion operator +(Quaternion a, Quaternion b)
    {
        return new Quaternion(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static Quaternion operator -(Quaternion a, Quaternion b)
    {
        return new Quaternion(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static Quaternion operator *(Quaternion a, Quaternion b)
    {
        double w = a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z;
        double x = a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y;
        double y = a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X;
        double z = a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W;

        return new Quaternion(w, x, y, z);
    }

    public double Norm()
    {
        return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
    }

    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }

    public Quaternion Inverse()
    {
        double normSquared = W * W + X * X + Y * Y + Z * Z;
        if (normSquared == 0)
            throw new InvalidOperationException("Quaternion has zero norm, cannot compute inverse.");

        double scale = 1 / normSquared;
        return new Quaternion(W * scale, -X * scale, -Y * scale, -Z * scale);
    }

    public double[,] ToRotationMatrix()
    {
        double[,] matrix = new double[3, 3];

        matrix[0, 0] = 1 - 2 * (Y * Y + Z * Z);
        matrix[0, 1] = 2 * (X * Y - W * Z);
        matrix[0, 2] = 2 * (X * Z + W * Y);

        matrix[1, 0] = 2 * (X * Y + W * Z);
        matrix[1, 1] = 1 - 2 * (X * X + Z * Z);
        matrix[1, 2] = 2 * (Y * Z - W * X);

        matrix[2, 0] = 2 * (X * Z - W * Y);
        matrix[2, 1] = 2 * (Y * Z + W * X);
        matrix[2, 2] = 1 - 2 * (X * X + Y * Y);

        return matrix;
    }

    public static Quaternion FromRotationMatrix(double[,] matrix)
    {
        double trace = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
        double w, x, y, z;

        if (trace > 0)
        {
            double s = 0.5 / Math.Sqrt(trace + 1.0);
            w = 0.25 / s;
            x = (matrix[2, 1] - matrix[1, 2]) * s;
            y = (matrix[0, 2] - matrix[2, 0]) * s;
            z = (matrix[1, 0] - matrix[0, 1]) * s;
        }
        else if (matrix[0, 0] > matrix[1, 1] && matrix[0, 0] > matrix[2, 2])
        {
            double s = 2.0 * Math.Sqrt(1.0 + matrix[0, 0] - matrix[1, 1] - matrix[2, 2]);
            w = (matrix[2, 1] - matrix[1, 2]) / s;
            x = 0.25 * s;
            y = (matrix[0, 1] + matrix[1, 0]) / s;
            z = (matrix[0, 2] + matrix[2, 0]) / s;
        }
        else if (matrix[1, 1] > matrix[2, 2])
        {
            double s = 2.0 * Math.Sqrt(1.0 + matrix[1, 1] - matrix[0, 0] - matrix[2, 2]);
            w = (matrix[0, 2] - matrix[2, 0]) / s;
            x = (matrix[0, 1] + matrix[1, 0]) / s;
            y = 0.25 * s;
            z = (matrix[1, 2] + matrix[2, 1]) / s;
        }
        else
        {
            double s = 2.0 * Math.Sqrt(1.0 + matrix[2, 2] - matrix[0, 0] - matrix[1, 1]);
            w = (matrix[1, 0] - matrix[0, 1]) / s;
            x = (matrix[0, 2] + matrix[2, 0]) / s;
            y = (matrix[1, 2] + matrix[2, 1]) / s;
            z = 0.25 * s;
        }

        return new Quaternion(w, x, y, z);
    }

    public static bool operator ==(Quaternion a, Quaternion b)
    {
        return a.W == b.W && a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }

    public static bool operator !=(Quaternion a, Quaternion b)
    {
        return !(a == b);
    }
}