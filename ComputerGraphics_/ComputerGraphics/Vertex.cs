namespace ComputerGraphics
{
    public class Vertex
    {
        public double[] Components;

        public Vertex(double[] components)
        {
            Components = components;
        }

        public double this[int index]
        {
            get => Components[index];
        }
    }
}