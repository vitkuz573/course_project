using System.Drawing;
using course_project.Properties;

namespace course_project.Fishes
{
    internal class Pike : Fish
    {
        public Size Speed;

        public Pike(Point data) : base(Color.Green)
        {
            Data = Coordinates = data;

            Size = new Size(80, 80);

            Speed = new Size(5, 5);
        }

        public Pike Next { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Resources.pike_to_right, Coordinates.X, Coordinates.Y, Size.Width, Size.Height);
            //graphics.FillEllipse(Brush, Coordinates.X, Coordinates.Y, Size.Width, Size.Height);
        }

        public Point UpdateLocation(Rectangle bounds)
        {
            if (!bounds.Contains(Coordinates + Speed))
            {
                if (Coordinates.X + Speed.Width < bounds.Left ||
                    Coordinates.X + Speed.Width > bounds.Right - Size.Width) Speed.Width *= -1;

                if (Coordinates.Y + Speed.Height < bounds.Top ||
                    Coordinates.Y + Speed.Height > bounds.Bottom - Size.Height) Speed.Height *= -1;
            }

            Coordinates += Speed;

            return Coordinates;
        }
    }
}