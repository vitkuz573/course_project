using System.Drawing;

namespace course_project
{
    internal class Pike<T> : Fish
    {
        readonly Brush brush = new SolidBrush(Color.Green);
        readonly AquariumForm aquarium;

        public Pike(T data, AquariumForm aquariumForm) {
            Data = data;

            aquarium = aquariumForm;

            Draw((int[])(object)data);
        }

        public T Data { get; set; }

        public Pike<T> Next { get; set; }

        protected override void Draw(int[] coordinates)
        {
            Graphics graphics = Graphics.FromImage(aquarium.Aquarium.Image);

            graphics.FillEllipse(brush, coordinates[0], coordinates[1], 40, 40);

            aquarium.Refresh();
        }
    }
}
