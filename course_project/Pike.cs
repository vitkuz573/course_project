using System.Drawing;

namespace course_project
{
    internal class Pike<T> : Fish
    {
        readonly Brush brush = new SolidBrush(Color.Green);
        readonly AquariumForm aquarium_form;

        public Pike(T data, AquariumForm aquariumForm) {
            Data = data;

            aquarium_form = aquariumForm;

            Draw((int[])(object)data);
        }

        public T Data { get; set; }

        public Pike<T> Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium_form.Aquarium.Image);

            graphics.FillEllipse(brush, coordinates[0], coordinates[1], 40, 40);

            aquarium_form.Refresh();
        }
    }
}
