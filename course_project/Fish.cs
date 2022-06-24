using System.Drawing;

namespace course_project
{
    public class Fish
    {
        protected readonly Brush brush;
        protected Point coordinates;
        protected Size size;
        protected Size speed;

        public Fish(Color color)
        {
            brush = new SolidBrush(color);

            speed = new Size(5, 5);
        }

        public Point Data { get; set; }

        public virtual void Draw(Graphics graphics)
        { }

        public void UpdateLocation(Rectangle bounds)
        {
            if (!bounds.Contains(coordinates + speed))
            {
                if (coordinates.X + speed.Width < bounds.Left || coordinates.X + speed.Width > bounds.Right - size.Width)
                {
                    speed.Width *= -1;
                }

                if (coordinates.Y + speed.Height < bounds.Top || coordinates.Y + speed.Height > bounds.Bottom - size.Height)
                {
                    speed.Height *= -1;
                }
            }

            coordinates += speed;
        }
    }
}