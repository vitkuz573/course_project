using System.Drawing;
using System.Windows.Forms;

namespace course_project
{
    internal class Pike<T> : Fish
    {
        Brush brush = new SolidBrush(Color.Green);
        AquariumForm aquarium;

        public Pike(T data, AquariumForm aquariumForm) {
            Data = data;

            aquarium = aquariumForm;

            Draw((int[])(object)data);
        }

        public T Data { get; set; }

        public Pike<T> Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium.getAquarium().Image);

            graphics.FillEllipse(brush, coordinates[0], coordinates[1], 40, 40);

            aquarium.Refresh();
        }
    }
}
