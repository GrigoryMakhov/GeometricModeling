using System.Drawing;

namespace ComputerGraphics
{
    public class Polygon
    {
        private readonly Vertex[] _vertices;

        public Polygon(Vertex[] vertices)
        {
            _vertices = vertices;
        }

        public PointF[] ProjectToScreen(Camera camera)
        {
            PointF[] points = new PointF[_vertices.Length];
            for (int i = 0; i < points.Length; i++)
                points[i] = camera.ProjectToScreen(_vertices[i]);
            return points;
        }
    }
}