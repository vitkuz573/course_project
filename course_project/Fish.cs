using System.Drawing;

namespace course_project
{
    internal class Fish
    {
        private protected Brush brush;

        public Fish(Color color)
        {
            brush = new SolidBrush(color);
        }

        public virtual void Draw(Graphics graphics) { }

        public Point Data { get; set; }
    }
}
