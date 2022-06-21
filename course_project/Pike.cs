using System.Drawing;

namespace course_project
{
    internal class Pike : Fish
    {
        readonly RectangleF rectangleF;

        public Pike(int[] data, AquariumForm aquariumForm) {
            Data = data;

            brush = new SolidBrush(Color.Green);
            aquarium_form = aquariumForm;

            rectangleF = new RectangleF(data[0], data[1], 40, 40);

            Draw();
        }

        public Pike Next { get; set; }

        protected override void Draw()
        {
            Graphics graphics = Graphics.FromImage(aquarium_form.AquariumPictureBox.Image);

            graphics.FillEllipse(brush, rectangleF);

            aquarium_form.Refresh();
        }
    }
}
