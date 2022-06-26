using System.Drawing;

namespace course_project.Fishes
{
    internal class Carp : Fish
    {
        public Size Speed;

        public Carp(Point data) : base(Color.Red)
        {
            Data = Coordinates = data;

            Size = new Size(40, 40);

            Speed = new Size(5, 5);
        }

        public Carp Next { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brush, Coordinates.X, Coordinates.Y, Size.Width, Size.Height);
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