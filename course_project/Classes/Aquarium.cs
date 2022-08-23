namespace CourseProject.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using CourseProject.Classes.Flocks;

    /// <summary>
    /// The aquarium.
    /// </summary>
    internal static class Aquarium
    {
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

        private static Random Random;

        /// <summary>
        /// Initializes static members of the <see cref="Aquarium"/> class.
        /// </summary>
        static Aquarium()
        {
            PikeFlock = new PikeFlock();
            CarpFlock = new CarpFlock();
            WaterColor = Color.LightSkyBlue;
            RocksColor = Color.DarkGray;
            RocksCount = AquariumRandom.Next(2, 5);
            RocksTopCoordinates = new List<PointF[]>();

            for (var i = 0; i < RocksCount; i++)
            {
                RocksTopCoordinates.Add(new[] { new PointF(Random.Next(0, 400), Random.Next(0, 400)), });
            }
        }

        /// <summary>
        /// Gets the random.
        /// </summary>
        public static Random AquariumRandom => Random ?? (Random = new Random());

        /// <summary>
        /// Gets the carp flock.
        /// </summary>
        public static CarpFlock CarpFlock { get; }

        /// <summary>
        /// Gets the pike flock.
        /// </summary>
        public static PikeFlock PikeFlock { get; }

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
            return new Point(AquariumRandom.Next(0, aquariumRectangle.Width), AquariumRandom.Next(0, aquariumRectangle.Height));
        }
    }
}