using System;
using System.Drawing;

namespace course_project
{
    internal class Aquarium
    {
        public PikeFlock pikeFlock;
        public CarpFlock carpFlock;
        public Color waterColor;
        public Color rocksColor;
        public Random random;
        public Rectangle client_rectangle;

        public Aquarium(Rectangle clientRectangle)
        {
            waterColor = Color.LightSkyBlue;
            rocksColor = Color.DarkGray;
            pikeFlock = new PikeFlock();
            carpFlock = new CarpFlock();
            random = new Random();

            client_rectangle = clientRectangle;
        }

        public void Init(Graphics graphics)
        {
            graphics.Clear(waterColor);

            foreach (Pike pike in pikeFlock)
                pike.Draw(graphics);

            foreach (Carp carp in carpFlock)
                carp.Draw(graphics);
        }

        public void Run()
        { }

        public void Done()
        { }

        public Point FishCoordinates()
        {
            return new Point(random.Next(0, client_rectangle.Height));
        }
    }
}