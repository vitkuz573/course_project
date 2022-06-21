using System.Drawing;

namespace course_project
{
    internal class Carp : Fish
    {
        readonly Rectangle rectangle;

        public Carp(int[] data, AquariumForm aquariumForm)
        {
            Data = data;

            brush = new SolidBrush(Color.Red);
            aquarium_form = aquariumForm;

            graphics = Graphics.FromImage(aquarium_form.AquariumPictureBox.Image);
            rectangle = new Rectangle(data[0], data[1], 50, 20);

            Draw();
        }

        public Carp Next { get; set; }

        protected override void Draw()
        {
            graphics.FillRectangle(brush, rectangle);

            aquarium_form.Refresh();
        }
    }
}
