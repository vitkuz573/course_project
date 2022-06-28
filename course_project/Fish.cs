using System;
using System.Drawing;

namespace course_project
{
    public class Fish
    {
        protected readonly Random random;
        protected Point coordinates;
        protected Image image;
        protected Size size;
        protected Size speed;

        public Fish()
        {
            random = new Random();
        }

        public Point Data { get; set; }

        public virtual void Draw(Graphics graphics)
        {
        }
    }
}