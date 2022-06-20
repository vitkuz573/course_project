using System.Drawing;

namespace course_project
{
    internal class Carp : Fish
    {
        public Carp(int[] data, AquariumForm aquariumForm)
        {
            Data = data;

            brush = new SolidBrush(Color.Red);
            aquarium_form = aquariumForm;

            Draw(data);
        }

        public Carp Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium_form.AquariumPictureBox.Image);

            graphics.FillRectangle(brush, coordinates[0], coordinates[1], 50, 20);

            aquarium_form.Refresh();
        }
    }
}
