using System.Drawing;

namespace course_project
{
    public class Fish
    {
        protected readonly Brush Brush;
        protected Point Coordinates;
        protected Size Size;

        public Fish(Color color)
        {
            Brush = new SolidBrush(color);
        }

        public Point Data { get; set; }

        public virtual void Draw(Graphics graphics)
        {
        }
    }
}