using System;

namespace ComputerGraphics
{
    public class Matrix
    {
        private readonly double[,] _matrix;
        private readonly int _width, _height;

        public Matrix(double[,] matrix)
        {
            _matrix = matrix;
            _width = matrix.GetLength(0);
            _height = matrix.GetLength(1);
        }

        public double[] Multiply(double[] vector)
        {
            if (vector.Length != _height)
                throw new Exception("Количество компонентов вектора не совпадает с высотой матрицы");

            double[] newVector = new double[_width];
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                    newVector[x] += vector[y] * _matrix[y, x];
            }
            double last = newVector[_width - 1];
            if (last != 1)
            {
                for (int i = 0; i < _width; i++)
                    newVector[i] /= last;
            }
            return newVector;
        }

        public static Matrix GetParallelTransferMatrix(double[] vector)
        {
            double[,] matrix = new double[,]
            {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { vector[0], vector[1], vector[2], 1 }
            };
            return new Matrix(matrix);
        }

        public static Matrix GetRotateMatrix(int axis, double angle)
        {
            double sin = Math.Sin(angle / 180 * Math.PI);
            double cos = Math.Cos(angle / 180 * Math.PI);
            double[,] matrix = new double[,]
            {
                { cos, -sin, sin, 0 },
                { sin, cos, -sin, 0 },
                { -sin, sin, cos, 0 },
                { 0, 0, 0, 1 }
            };
            for (int i = 0; i < 3; i++)
            {
                if (axis != i)
                {
                    matrix[axis, i] = 0;
                    matrix[i, axis] = 0;
                }
            }
            matrix[axis, axis] = 1;
            return new Matrix(matrix);
        }

        public static Matrix GetObliqueShiftMatrix(int axis, int alongAxis, double factor)
        {
            double[,] matrix = new double[,]
            {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
            matrix[alongAxis, axis] = factor;
            return new Matrix(matrix);
        }

        public static Matrix GetScaleMatrix(int axis, double scale)
        {
            return GetObliqueShiftMatrix(axis, axis, scale);
        }

        public static Matrix GetFullScaleMatrix(double scale)
        {
            double[,] matrix = new double[,]
            {
                { scale, 0, 0, 0 },
                { 0, scale, 0, 0 },
                { 0, 0, scale, 0 },
                { 0, 0, 0, 1 }
            };
            return new Matrix(matrix);
        }

        public static Matrix GetOPPMatrix(int axis, double focalLength)
        {
            double[,] matrix = new double[,]
            {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
            matrix[axis, 3] = 1.0 / focalLength;
            return new Matrix(matrix);
        }
    }
}