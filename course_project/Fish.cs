using System.Drawing;

namespace course_project
{
    internal class Fish
    {
        private protected Graphics graphics;
        private protected Brush brush;
        private protected AquariumForm aquarium_form;

        public Fish(Color color)
        {
            brush = new SolidBrush(color);
        }

        protected virtual void Draw() { }

        public int[] Data { get; set; }
    }
}
