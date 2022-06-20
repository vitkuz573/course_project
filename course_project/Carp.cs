using System.Drawing;

namespace course_project
{
    internal class Carp<T> : Fish
    {
        Brush brush = new SolidBrush(Color.Red);
        AquariumForm aquarium;

        public Carp(T data, AquariumForm aquariumForm) {
            Data = data;

            aquarium = aquariumForm;

            Draw((int[])(object)data);
        }

        public T Data { get; set; }

        public Carp<T> Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium.getAquarium().Image);

            graphics.FillRectangle(brush, coordinates[0], coordinates[1], 50, 20);

            aquarium.Refresh();
        }
    }
}
