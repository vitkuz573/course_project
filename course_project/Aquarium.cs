using System;
using System.Drawing;
using course_project.Flocks;

namespace course_project
{
    internal class Aquarium
    {
        private readonly Rectangle _clientRectangle;
        private readonly Random _random;
        private readonly Color _rocksColor;
        private readonly Color _waterColor;
        public readonly CarpFlock carpFlock;
        public readonly PikeFlock pikeFlock;

        public Aquarium(Rectangle client)
        {
            pikeFlock = new PikeFlock();
            carpFlock = new CarpFlock();
            _clientRectangle = client;
            _random = new Random();
            _waterColor = Color.LightSkyBlue;
            _rocksColor = Color.DarkGray;
        }

        public void Init(Graphics graphics)
        {
            graphics.Clear(_waterColor);

            graphics.FillPolygon(new SolidBrush(_rocksColor), new PointF[]
            {
                new Point(160, _clientRectangle.Bottom),
                new Point(40, _clientRectangle.Bottom),
                new Point(67, 80)
            });

            graphics.FillPolygon(new SolidBrush(_rocksColor), new PointF[]
            {
                new Point(360, _clientRectangle.Bottom),
                new Point(300, _clientRectangle.Bottom),
                new Point(280, 300)
            });

            foreach (var pike in pikeFlock)
                pike.Draw(graphics);

            foreach (var carp in carpFlock)
                carp.Draw(graphics);
        }

        public Point RandomPoint() => new Point(_random.Next(0, _clientRectangle.Width), _random.Next(0, _clientRectangle.Height));
    }
}