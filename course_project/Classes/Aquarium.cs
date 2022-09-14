namespace CourseProject.Classes
{
    using System;
    using System.Drawing;
    using CourseProject.Classes.Extensions;
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
        /// The rocks top coordinates.
        /// </summary>
        private static readonly Point[] RocksTopCoordinates;

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
        /// The random.
        /// </summary>
        private static Random random;

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
            RocksTopCoordinates = new Point[RocksCount];

            for (var i = 0; i < RocksCount; i++)
            {
                if (random != null)
                {
                    RocksTopCoordinates[i] = new Point(random.Next(0, 400), random.Next(0, 400));
                }
            }
        }

        /// <summary>
        /// Gets the random.
        /// </summary>
        public static Random AquariumRandom => random ?? (random = new Random());

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
                graphics.FillTriangle(new SolidBrush(RocksColor), new Point(aquarium.Width, aquarium.Bottom), new Point(aquarium.Height, aquarium.Bottom), RocksTopCoordinates[i]);
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