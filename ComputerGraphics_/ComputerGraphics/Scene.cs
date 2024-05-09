using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ComputerGraphics
{
    public class Scene
    {
        private readonly Bitmap _bitmap;
        private readonly Graphics _graphics;
        private readonly List<Vertex> _vertices;
        private readonly List<Polygon> _polygons;

        public readonly int Width, Height;

        public Scene(List<Vertex> vertices, List<Polygon> polygons, int width, int height)
        {
            Width = width;
            Height = height;
            _vertices = vertices;
            _polygons = polygons;
            _bitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_bitmap);
        }

        public (PointF, PointF) GetSceneRectangle()
        {
            double minX = double.MaxValue;
            double minY = double.MaxValue;
            double maxX = double.MinValue;
            double maxY = double.MinValue;

            foreach (Vertex vertex in _vertices)
            {
                if (vertex[0] > maxX)
                    maxX = vertex[0];
                if (vertex[0] < minX)
                    minX = vertex[0];
                if (vertex[1] > maxY)
                    maxY = vertex[1];
                if (vertex[1] < minY)
                    minY = vertex[1];
            }
            return (new PointF((float)minX, (float)minY), new PointF((float)maxX, (float)maxY));
        }

        public Bitmap Draw(Camera camera)
        {
            Pen pen = new(Brushes.LightBlue, 1);
            _graphics.Clear(Color.Black);
            
            foreach (Polygon polygon in _polygons)
            {
                PointF[] points = polygon.ProjectToScreen(camera);
                _graphics.DrawPolygon(pen, ProjectToBitmap(points, camera.ScreenSize * 2));
            }
            return _bitmap;
        }

        private PointF[] ProjectToBitmap(PointF[] points, double screenSize)
        {
            PointF[] result = new PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                double x = (points[i].X / screenSize + 0.5) * Width;
                double y = (-points[i].Y / screenSize + 0.5) * Height;
                result[i] = new PointF((float)x, (float)y);
            }
            return result;
        }

        public void ApplyMatrix(Matrix matrix)
        {
            for (int i = 0; i < _vertices.Count; i++)
                _vertices[i].Components = matrix.Multiply(_vertices[i].Components);
        }

        public void ApplyMatrixToCenter(Matrix matrix)
        {
            double[] center = GetCenter();
            var transferMatrix = Matrix.GetParallelTransferMatrix(center.Select(c => -c).ToArray());
            ApplyMatrix(transferMatrix);
            ApplyMatrix(matrix);
            ApplyMatrix(Matrix.GetParallelTransferMatrix(center));
        }

        public double[] GetCenter()
        {
            double[] center = new double[_vertices[0].Components.Length];
            foreach (var vertex in _vertices)
            {
                for (int i = 0; i < vertex.Components.Length; i++)
                    center[i] += vertex.Components[i];
            }
            for (int i = 0; i < center.Length; i++)
                center[i] /= _vertices.Count;

            return center;
        }
    }
}