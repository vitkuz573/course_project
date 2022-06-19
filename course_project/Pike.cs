using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    internal class Pike<T> : Fish
    {
        Brush brush = new SolidBrush(Color.Green);
        public PictureBox aquarium = new AquariumForm().aquarium_picturebox;

        public Pike(T data) {
            Data = data;

            Draw((int[])(object)data);
        }

        public T Data { get; set; }

        public Pike<T> Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium.Image);

            graphics.FillEllipse(brush, coordinates[0], coordinates[1], 40, 40);

            aquarium.Refresh();
        }
    }
}
