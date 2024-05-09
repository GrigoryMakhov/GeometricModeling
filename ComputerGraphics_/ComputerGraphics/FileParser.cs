using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ComputerGraphics
{
    public class FileParser
    {
        public static List<Vertex> ParseVertices(string fileName, int componentsCount)
        {
            string[] lines = File.ReadAllLines(fileName);
            if (lines.Length == 0)
                throw FileIsCorruptedException();

            if (!int.TryParse(lines[0], out int verticesCount) || verticesCount >= lines.Length)
                throw FileIsCorruptedException();

            List<Vertex> vertices = new List<Vertex>();
            for (int i = 1; i <= verticesCount; i++)
            {
                string[] componentsStr = lines[i].Split(' ');
                if (componentsStr.Length != componentsCount)
                    throw FileIsCorruptedException();

                double[] components = new double[componentsCount + 1];
                for (int j = 0; j < componentsCount; j++)
                {
                    if (!double.TryParse(componentsStr[j], NumberStyles.Any, CultureInfo.InvariantCulture, out components[j]))
                        throw FileIsCorruptedException();
                }
                components[componentsCount] = 1;
                vertices.Add(new Vertex(components));
            }
            return vertices;
        }

        public static List<Polygon> ParsePolygons(string fileName, int polygonsBegin, List<Vertex> vertices)
        {
            string[] lines = File.ReadAllLines(fileName);
            if (lines.Length <= polygonsBegin)
                throw FileIsCorruptedException();

            if (!int.TryParse(lines[polygonsBegin], out int polygonsCount))
                throw FileIsCorruptedException();

            int polygonsEnd = polygonsBegin + polygonsCount;
            if (polygonsEnd >= lines.Length)
                throw FileIsCorruptedException();

            List<Polygon> polygons = new List<Polygon>();
            for (int i = polygonsBegin + 1; i <= polygonsEnd; i++)
            {
                string[] componentsStr = lines[i].Split(' ');

                int[] components = new int[componentsStr.Length];
                for (int j = 0; j < componentsStr.Length; j++)
                {
                    if (!int.TryParse(componentsStr[j], NumberStyles.Any, CultureInfo.InvariantCulture, out components[j]))
                        throw FileIsCorruptedException();
                    if (components[j] >= vertices.Count)
                        throw FileIsCorruptedException();
                }

                Vertex[] polygon = new Vertex[components.Length];
                for (int j = 0; j < components.Length; j++)
                    polygon[j] = vertices[components[j]];
                polygons.Add(new Polygon(polygon));
            }
            return polygons;
        }

        private static Exception FileIsCorruptedException()
        {
            return new Exception("Файл поврежден");
        }
    }
}