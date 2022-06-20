using System.Drawing;

namespace course_project
{
    internal class Carp<T> : Fish
    {
        readonly Brush brush = new SolidBrush(Color.Red);
        readonly AquariumForm aquarium_form;

        public Carp(T data, AquariumForm aquariumForm) {
            Data = data;

            aquarium_form = aquariumForm;

            Draw((int[])(object)data);
        }

        public T Data { get; set; }

        public Carp<T> Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium_form.Aquarium.Image);

            graphics.FillRectangle(brush, coordinates[0], coordinates[1], 50, 20);

            aquarium_form.Refresh();
        }
    }
}
