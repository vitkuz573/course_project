using System.Drawing;
using course_project.Properties;

namespace course_project.Fishes
{
    internal class Carp : Fish
    {
        public Carp(Point data)
        {
            Data = data;

            size = new Size(40, 40);

            image = speed.Width < 0
                ? Resources.carp_to_left
                : Resources.carp_to_right;
        }

        public Carp Next { get; set; }

        public override void Draw(Graphics graphics) => graphics.DrawImage(image, Data.X, Data.Y, size.Width, size.Height);
    }
}