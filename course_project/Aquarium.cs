namespace CourseProject
{
    using System;
    using System.Drawing;

    using CourseProject.Flocks;

    /// <summary>
    /// The aquarium.
    /// </summary>
    internal class Aquarium
    {
        /// <summary>
        /// The carp flock.
        /// </summary>
        public readonly CarpFlock CarpFlock;

        /// <summary>
        /// The pike flock.
        /// </summary>
        public readonly PikeFlock PikeFlock;

        /// <summary>
        /// The random.
        /// </summary>
        private readonly Random random;

        /// <summary>
        /// The rocks color.
        /// </summary>
        private readonly Color rocksColor;

        /// <summary>
        /// The water color.
        /// </summary>
        private readonly Color waterColor;

        /// <summary>
        /// The clip rectangle.
        /// </summary>
        private Rectangle clipRectangle;

        /// <summary>
        /// Initializes a new instance of the <see cref="Aquarium"/> class.
        /// </summary>
        public Aquarium()
        {
            this.PikeFlock = new PikeFlock();
            this.CarpFlock = new CarpFlock();
            this.random = new Random();
            this.waterColor = Color.LightSkyBlue;
            this.rocksColor = Color.DarkGray;
        }

        /// <summary>
        /// The init.
        /// </summary>
        /// <param name="graphics">
        /// The graphics.
        /// </param>
        /// <param name="clip">
        /// The clip.
        /// </param>
        public void Init(Graphics graphics, Rectangle clip)
        {
            this.clipRectangle = clip;

            graphics.Clear(this.waterColor);

            graphics.FillPolygon(
                new SolidBrush(this.rocksColor),
                new[] { new PointF(50, clip.Bottom), new PointF(250, clip.Bottom), new PointF(90, 100) });

            graphics.FillPolygon(
                new SolidBrush(this.rocksColor),
                new[] { new PointF(260, clip.Bottom), new PointF(600, clip.Bottom), new PointF(300, 100) });

            foreach (var pike in this.PikeFlock)
            {
                pike.Draw(graphics);
            }

            foreach (var carp in this.CarpFlock)
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
        public Point RandomPoint()
        {
            return new Point(
                this.random.Next(0, this.clipRectangle.Width),
                this.random.Next(0, this.clipRectangle.Height));
        }
    }
}