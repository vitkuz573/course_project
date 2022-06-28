using System.Drawing;
using course_project.Properties;

namespace course_project.Fishes
{
    internal class Pike : Fish
    {
        public Pike(Point data)
        {
            Data = coordinates = data;

            size = new Size(80, 80);

            speed = new Size(random.Next(-5, 5), random.Next(-5, 5));

            image = speed.Width < 0
                ? Resources.pike_to_left
                : Resources.pike_to_right;
        }

        public Pike Next { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(image, coordinates.X, coordinates.Y, size.Width, size.Height);
        }

        public Point UpdateLocation(Rectangle bounds)
        {
            if (!bounds.Contains(coordinates + speed))
            {
                if (coordinates.X + speed.Width < bounds.Left ||
                    coordinates.X + speed.Width > bounds.Right - size.Width) speed.Width *= -1;

                if (coordinates.Y + speed.Height < bounds.Top ||
                    coordinates.Y + speed.Height > bounds.Bottom - size.Height) speed.Height *= -1;
            }

            coordinates += speed;

            return coordinates;
        }
    }
}