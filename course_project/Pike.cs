using System.Drawing;

namespace course_project
{
    internal class Pike : Fish
    {
        public Pike(Point data) : base(Color.Green)
        {
            Data = data;

            size = new Size(40, 40);
        }

        public Pike Next { get; set; }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(brush, coordinates.X, coordinates.Y, size.Width, size.Height);
        }

        public new Size speed
        {
            set
            {
                base.speed = value;
            }
        }
    }
}
