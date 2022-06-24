using System.Drawing;

namespace course_project
{
    internal class Carp : Fish
    {
        public Carp(Point data) : base(Color.Red)
        {
            Data = coordinates = data;

            size = new Size(40, 40);
        }

        public Carp Next { get; set; }

        public new Size speed
        {
            set => base.speed = value;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(brush, coordinates.X, coordinates.Y, size.Width, size.Height);
        }
    }
}