using System;
using System.Drawing;

namespace course_project
{
    internal class Aquarium
    {
        public PikeFlock pikeFlock;
        public CarpFlock carpFlock;
        public Color waterColor;
        public Color rocksSolor;
        public Random random;

        public Aquarium()
        {
            waterColor = Color.LightSkyBlue;
            rocksSolor = Color.DarkGray;
            pikeFlock = new PikeFlock();
            carpFlock = new CarpFlock();
            random = new Random();
        }

        public void Init(Graphics graphics) {
            graphics.Clear(waterColor);

            for (int i = 0; i < random.Next(3, 8); i++) {
                graphics.FillRectangle(new SolidBrush(rocksSolor), 50, 0, 50, 80);
            }

            foreach (Pike pike in pikeFlock)
                pike.Draw(graphics);

            foreach (Carp carp in carpFlock)
                carp.Draw(graphics);
        }

        public void Run() { }

        public void Done() { }
    }
}
