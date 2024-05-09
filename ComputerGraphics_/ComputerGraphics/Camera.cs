using System.Drawing;

namespace ComputerGraphics
{
    public class Camera
    {
        public readonly double ScreenSize;

        public double X { get; set; }
        public double Y { get; set; }

        public Camera(double screenSize)
        {
            ScreenSize = screenSize;
            X = 0;
            Y = 0;
        }

        public PointF ProjectToScreen(Vertex vertex)
        {
            if (vertex.Components.Length < 2)
                return PointF.Empty;

            return new PointF((float)(vertex[0] - X), (float)(vertex[1] - Y));
        }
    }
}