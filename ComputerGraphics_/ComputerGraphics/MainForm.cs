using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ComputerGraphics
{
    public partial class MainForm : Form
    {
        private Camera _camera;
        private Scene _scene;

        public MainForm()
        {
            InitializeComponent();
            _camera = new Camera(Configuration.ScreenSize);
        }

        private void OpenButtonClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string fileName = openFileDialog.FileName;
            if (string.IsNullOrEmpty(fileName))
                return;

            if (!File.Exists(fileName))
                return;

            List<Vertex> vertices;
            List<Polygon> polygons;
            try
            {
                vertices = FileParser.ParseVertices(fileName, Configuration.VertexComponentsCount);
                polygons = FileParser.ParsePolygons(fileName, vertices.Count + 1, vertices);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _scene = new Scene(vertices, polygons, pictureBox.Width, pictureBox.Height);
            drawTimer.Enabled = true;
        }

        private void DrawTimerTick(object sender, EventArgs e)
        {
            pictureBox.Image = _scene.Draw(_camera);
        }

        private bool ParseOrMessage(string s, out double result)
        {
            if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
                return true;

            MessageBox.Show(this, "Введены неправильные числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void ParallelTransferButtonClick(object sender, EventArgs e)
        {
            if (!ParseOrMessage(parallelTransferX.Text, out double x))
                return;
            if (!ParseOrMessage(parallelTransferY.Text, out double y))
                return;
            if (!ParseOrMessage(parallelTransferZ.Text, out double z))
                return;

            double[] vector = new[] { x, y, z };
            Matrix matrix = Matrix.GetParallelTransferMatrix(vector);
            _scene.ApplyMatrix(matrix);
        }

        private void ScaleButtonClick(object sender, EventArgs e)
        {
            if (!ParseOrMessage(scaleTextBox.Text, out double scale))
                return;

            Matrix matrix;
            if (scaleAxisRadioAll.Checked)
                matrix = Matrix.GetFullScaleMatrix(scale);
            else
            {
                int axis = 0;
                if (scaleAxisRadioY.Checked)
                    axis = 1;
                else if (scaleAxisRadioZ.Checked)
                    axis = 2;

                matrix = Matrix.GetScaleMatrix(axis, scale);
            }

            _scene.ApplyMatrixToCenter(matrix);
        }

        private void RotateButtonClick(object sender, EventArgs e)
        {
            if (!ParseOrMessage(rotateTextBox.Text, out double angle))
                return;

            int axis = 0;
            if (rotateAxisRadioY.Checked)
                axis = 1;
            else if (rotateAxisRadioZ.Checked)
                axis = 2;

            Matrix matrix = Matrix.GetRotateMatrix(axis, angle);
            _scene.ApplyMatrixToCenter(matrix);
        }

        private void ObliqueShiftButtonClick(object sender, EventArgs e)
        {
            if (!ParseOrMessage(obliqueShiftFactor.Text, out double factor))
                return;

            int axis = 0;
            if (obliqueShiftAxisY.Checked)
                axis = 1;
            else if (obliqueShiftAxisZ.Checked)
                axis = 2;

            int alongAxis = 0;
            if (obliqueShiftAlongAxisY.Checked)
                alongAxis = 1;
            else if (obliqueShiftAlongAxisZ.Checked)
                alongAxis = 2;

            if (axis == alongAxis)
            {
                MessageBox.Show(this, "Нельзя выбрать одинаковые оси", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Matrix matrix = Matrix.GetObliqueShiftMatrix(axis, alongAxis, factor);
            _scene.ApplyMatrixToCenter(matrix);
        }

        private void OppButtonClick(object sender, EventArgs e)
        {
            if (!ParseOrMessage(oppTextBox.Text, out double focalLength))
                return;

            int axis = 0;
            if (oppAxisRadioY.Checked)
                axis = 1;
            else if (oppAxisRadioZ.Checked)
                axis = 2;

            Matrix matrix = Matrix.GetOPPMatrix(axis, focalLength);
            _scene.ApplyMatrixToCenter(matrix);
        }

        private void FitIntoFrameButtonClick(object sender, EventArgs e)
        {
            var (minPoint, maxPoint) = _scene.GetSceneRectangle();
            _camera.X = (maxPoint.X + minPoint.X) / 2;
            _camera.Y = (maxPoint.Y + minPoint.Y) / 2;
            List<double> list = new List<double>
            {
                _camera.ScreenSize + minPoint.X - _camera.X,
                _camera.ScreenSize - maxPoint.X + _camera.X,
                _camera.ScreenSize + minPoint.Y - _camera.Y,
                _camera.ScreenSize - maxPoint.Y + _camera.Y
            };
            Matrix matrix = Matrix.GetFullScaleMatrix(_camera.ScreenSize / (_camera.ScreenSize - list.Min()));
            _scene.ApplyMatrixToCenter(matrix);
        }
    }
}