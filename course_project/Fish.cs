using System;
using System.Drawing;
using course_project.Extensions;

namespace course_project
{
    public class Fish
    {
        protected readonly Random random;
        protected Image image;
        protected Size size;
        protected Size speed;

        public Fish()
        {
            random = new Random();

            speed = new Size(random.NextWithExclude(-5, 5, new[] { 0 }), random.NextWithExclude(-5, 5, new[] { 0 }));
        }

        public Point Data { get; set; }

        public virtual void Draw(Graphics graphics)
        {
        }

        public void UpdateLocation(Rectangle bounds)
        {
            if (!bounds.Contains(Data + speed))
            {
                if (Data.X + speed.Width < bounds.Left || Data.X + speed.Width > bounds.Right - size.Width)
                {
                    speed.Width *= -1;
                    image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }

                if (Data.Y + speed.Height < bounds.Top || Data.Y + speed.Height > bounds.Bottom - size.Height)
                    speed.Height *= -1;
            }

            Data += speed;
        }
    }
}