using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    internal class Carp<T> : Fish
    {
        Brush brush = new SolidBrush(Color.Red);
        PictureBox aquarium = new AquariumForm().aquarium_picturebox;

        public Carp(T data) {
            Data = data;

            Draw((int[])(object)data);
        }

        public T Data { get; set; }

        public Carp<T> Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium.Image);

            graphics.FillRectangle(brush, coordinates[0], coordinates[1], 50, 20);

            aquarium.Refresh();
        }

        public override string ToString()
        {
            return base.ToString() + ": " + Data.ToString();
        }
    }
}
