using System.Drawing;

namespace course_project
{
    internal class Carp : Fish
    {
        readonly Rectangle rectangle;

        public Carp(int[] data, AquariumForm aquariumForm) : base(Color.Red)
        {
            Data = data;

            aquarium_form = aquariumForm;

            graphics = Graphics.FromImage(aquarium_form.AquariumPictureBox.Image);
            rectangle = new Rectangle(data[0], data[1], 50, 20);

            Draw();

            aquarium_form.Refresh();
        }

        public Carp Next { get; set; }

        protected override void Draw()
        {
            graphics.FillRectangle(brush, rectangle);
        }
    }
}
