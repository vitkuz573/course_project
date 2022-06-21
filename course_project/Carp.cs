using System.Drawing;

namespace course_project
{
    internal class Carp : Fish
    {
        readonly Rectangle figure;

        public Carp(int[] data, AquariumForm aquariumForm) : base(Color.Red, aquariumForm)
        {
            Data = data;

            figure = new Rectangle(data[0], data[1], 50, 20);

            Draw();

            aquarium_form.Refresh();
        }

        public Carp Next { get; set; }

        protected override void Draw()
        {
            graphics.FillRectangle(brush, figure);
        }
    }
}
