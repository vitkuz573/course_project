using System.Drawing;

namespace course_project
{
    internal class Pike : Fish
    {
        public Pike(int[] data, AquariumForm aquariumForm) {
            Data = data;

            brush = new SolidBrush(Color.Green);
            aquarium_form = aquariumForm;

            Draw(data);
        }

        public Pike Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium_form.AquariumPictureBox.Image);

            Rectangle rectangle = new Rectangle(coordinates[0], coordinates[1], 40, 40);

            graphics.FillEllipse(brush, rectangle);

            aquarium_form.Refresh();

            rectangle.Offset(50, 10);

            Thread.Sleep(10000);

            aquarium_form.Refresh();
        }
    }
}
