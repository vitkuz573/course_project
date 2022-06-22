using System.Drawing;

namespace course_project
{
    internal class Pike : Fish
    {
        private Point coordinates;
        private Size size = new Size(40, 40);
        private Size speed;

        public Pike(Point data, AquariumForm aquariumForm) : base(Color.Green, aquariumForm)
        {
            Data = data;

            speed = new Size(5, 5);
        }

        public Pike Next { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(brush, coordinates.X, coordinates.Y, size.Width, size.Height);
        }

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
