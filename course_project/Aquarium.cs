namespace CourseProject
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using CourseProject.Flocks;

    /// <summary>
    /// The aquarium.
    /// </summary>
    internal static class Aquarium
    {
        /// <summary>
        /// The carp flock.
        /// </summary>
        public static readonly CarpFlock CarpFlock;

        /// <summary>
        /// The pike flock.
        /// </summary>
        public static readonly PikeFlock PikeFlock;

        /// <summary>
        /// The aquarium random.
        /// </summary>
        public static readonly Random Random;

        /// <summary>
        /// The rocks color.
        /// </summary>
        private static readonly Color RocksColor;

        /// <summary>
        /// The rocks coordinates.
        /// </summary>
        private static readonly List<PointF[]> RocksTopCoordinates;

        /// <summary>
        /// The rocks count.
        /// </summary>
        private static readonly int RocksCount;

        /// <summary>
        /// The water color.
        /// </summary>
        private static readonly Color WaterColor;

        /// <summary>
        /// The aquarium rectangle.
        /// </summary>
        private static Rectangle aquariumRectangle;

        /// <summary>
        /// Initializes static members of the <see cref="Aquarium"/> class.
        /// </summary>
        static Aquarium()
        {
            Random = new Random();
            PikeFlock = new PikeFlock();
            CarpFlock = new CarpFlock();
            WaterColor = Color.LightSkyBlue;
            RocksColor = Color.DarkGray;
            RocksCount = Random.Next(2, 5);
            RocksTopCoordinates = new List<PointF[]>();

            for (var i = 0; i < RocksCount; i++)
            {
                RocksTopCoordinates.Add(new[] { new PointF(Random.Next(0, 400), Random.Next(0, 400)), });
            }
        }

        /// <summary>
        /// The init.
        /// </summary>
        /// <param name="graphics">
        /// The graphics.
        /// </param>
        /// <param name="aquarium">
        /// The aquarium.
        /// </param>
        public static void Init(Graphics graphics, Rectangle aquarium)
        {
            aquariumRectangle = aquarium;

            graphics.Clear(WaterColor);

            for (var i = 0; i < RocksCount; i++)
            {
                graphics.FillPolygon(
                    new SolidBrush(RocksColor),
                    new[] { new PointF(aquarium.Width, aquarium.Bottom), new PointF(aquarium.Height, aquarium.Bottom), RocksTopCoordinates[i][0] });
            }

            foreach (var pike in PikeFlock)
            {
                pike.Draw(graphics);
            }

            foreach (var carp in CarpFlock)
            {
                carp.Draw(graphics);
            }
        }

        /// <summary>
        /// The random point.
        /// </summary>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        public static Point RandomPoint()
        {
            return new Point(Random.Next(0, aquariumRectangle.Width), Random.Next(0, aquariumRectangle.Height));
        }
    }
}