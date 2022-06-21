using System.Drawing;

namespace course_project
{
    internal class Pike : Fish
    {
        readonly RectangleF circle;

        public Pike(int[] data, AquariumForm aquariumForm) : base(Color.Green)
        {
            Data = data;

            aquarium_form = aquariumForm;

            graphics = Graphics.FromImage(aquarium_form.AquariumPictureBox.Image);
            circle = new RectangleF(data[0], data[1], 40, 40);

            Draw();

            aquarium_form.Refresh();
        }

        public Pike Next { get; set; }

        protected override void Draw()
        {
            graphics.FillEllipse(brush, circle);
        }
    }
}
