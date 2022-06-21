using System.Drawing;

namespace course_project
{
    internal class Pike : Fish
    {
        readonly RectangleF figure;

        public Pike(int[] data, AquariumForm aquariumForm) : base(Color.Green, aquariumForm)
        {
            Data = data;

            figure = new RectangleF(data[0], data[1], 40, 40);

            Draw();

            aquarium_form.Refresh();
        }

        public Pike Next { get; set; }

        protected override void Draw()
        {
            graphics.FillEllipse(brush, figure);
        }
    }
}
