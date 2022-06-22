using System.Drawing;

namespace course_project
{
    public class Fish
    {
        private protected Brush brush;
        private protected Point coordinates;
        private protected Size size;
        public Size speed;

        public Fish(Color color)
        {
            brush = new SolidBrush(color);

            speed = new Size(5, 5);
        }

        public virtual void Draw(Graphics graphics) { }

        public Point Data { get; set; }

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
