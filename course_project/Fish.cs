using System.Drawing;

namespace course_project
{
    public class Fish
    {
        protected readonly Brush brush;
        protected Point coordinates;
        protected Size size;

        public Fish(Color color)
        {
            brush = new SolidBrush(color);
        }

        public Point Data { get; set; }

        public virtual void Draw(Graphics graphics)
        {
        }
    }
}