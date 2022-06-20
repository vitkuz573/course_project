using System.Drawing;

namespace course_project
{
    internal class Pike : Fish
    {
        readonly Brush brush = new SolidBrush(Color.Green);
        readonly AquariumForm aquarium_form;

        public Pike(int[] data, AquariumForm aquariumForm) {
            Data = data;

            aquarium_form = aquariumForm;

            Draw(data);
        }

        public int[] Data { get; set; }

        public Pike Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium_form.AquariumPictureBox.Image);

            graphics.FillEllipse(brush, coordinates[0], coordinates[1], 40, 40);

            aquarium_form.Refresh();
        }
    }
}
