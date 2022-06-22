using System.Drawing;

namespace course_project
{
    internal class Fish
    {
        private protected Brush brush;
        private protected AquariumForm aquarium_form;

        public Fish(Color color, AquariumForm aquariumForm)
        {
            aquarium_form = aquariumForm;

            brush = new SolidBrush(color);
        }

        public virtual void Draw(Graphics graphics) { }

        public Point Data { get; set; }
    }
}
