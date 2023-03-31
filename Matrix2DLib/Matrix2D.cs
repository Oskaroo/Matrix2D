

using System.Numerics;

namespace Matrix2DLib
{
    public class Matrix2D : IEquatable<Matrix2D>
    {
        public int A { get; init; }
        public int B { get; init; }
        public int C { get; init; }
        public int D { get; init; }

        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Matrix2D() : this(1, 0, 0, 1) { }

        public static Matrix2D Zero { get; } = new(0, 0, 0, 0);
        public static readonly Matrix2D Id = new();

        public override string ToString() => $"[ [{A},{B}], [{C},{D}]]";

        public bool Equals(Matrix2D? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return A == other.A && B == other.B && C == other.C && D == other.D;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false; // używaj is nie "=="
            if (obj is not Matrix2D) return false;

            //return Equals((Matrix2D)obj);   // zeby equals był z public bool Equals(Matrix2D? other)
            return Equals(obj as Matrix2D); // to samo co wyżej tylko nowsze rozwiązanie

        }

        public override int GetHashCode() => HashCode.Combine(A, B, C, D);

        public static bool operator ==(Matrix2D left, Matrix2D right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Matrix2D left, Matrix2D right) => !(left == right);

        public static Matrix2D operator +(Matrix2D matrix1, Matrix2D matrix2)
        {
            int outA = matrix1.A + matrix2.A;
            int outB = matrix1.B + matrix2.B;
            int outC = matrix1.C + matrix2.C;
            int outD = matrix1.D + matrix2.D;
            Matrix2D output = new (outA, outB, outC, outD);
            return output;
        }
        public static Matrix2D operator -(Matrix2D matrix1, Matrix2D matrix2)
        {
            int outA = matrix1.A - matrix2.A;
            int outB = matrix1.B - matrix2.B;
            int outC = matrix1.C - matrix2.C;
            int outD = matrix1.D - matrix2.D;
            Matrix2D output = new(outA, outB, outC, outD);
            return output;
        }
        public static Matrix2D operator *(Matrix2D matrix1, Matrix2D matrix2)
        {
            int outA = (matrix1.A * matrix2.A) + (matrix1.B * matrix2.C);
            int outB = (matrix1.A * matrix2.B) + (matrix1.B * matrix2.D);
            int outC = (matrix1.C * matrix2.A) + (matrix1.D * matrix2.C);
            int outD = (matrix1.C * matrix2.B) + (matrix1.D * matrix2.D);
            Matrix2D output = new(outA, outB, outC, outD);
            return output;
        }
        // public static bool operator (Matrix2D left, Matrix2D right)

    }
}
