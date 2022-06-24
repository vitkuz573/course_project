﻿using System;
using System.Drawing;
using course_project.Flocks;

namespace course_project
{
    internal class Aquarium
    {
        public readonly CarpFlock carpFlock;
        public readonly PikeFlock pikeFlock;
        private readonly Rectangle _clientRectangle;
        private readonly Random _random;
        private readonly Color _waterColor;
        private readonly Color _rocksColor;

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

            foreach (var pike in pikeFlock)
                pike.Draw(graphics);

            foreach (var carp in carpFlock)
                carp.Draw(graphics);
        }

        public void Run()
        {
        }

        public void Done()
        {
        }

        public Point RandomPoint()
        {
            return new Point(_random.Next(0, _clientRectangle.Width), _random.Next(0, _clientRectangle.Height));
        }
    }
}