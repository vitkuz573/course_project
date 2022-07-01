using System.Drawing;
using course_project.Properties;

namespace course_project.Fishes
{
    internal class Pike : Fish
    {
        public Pike(Point data)
        {
            Data = data;

            size = new Size(80, 80);

            image = speed.Width < 0
                ? Resources.pike_to_left
                : Resources.pike_to_right;
        }

        public Pike Next { get; set; }

        public override void Draw(Graphics graphics) => graphics.DrawImage(image, Data.X, Data.Y, size.Width, size.Height);
    }
}