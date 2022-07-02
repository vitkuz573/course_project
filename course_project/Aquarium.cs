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
        /// The client rectangle.
        /// </summary>
        private readonly Rectangle clientRectangle;

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
        /// Initializes a new instance of the <see cref="Aquarium"/> class.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        public Aquarium(Rectangle client)
        {
            this.PikeFlock = new PikeFlock();
            this.CarpFlock = new CarpFlock();
            this.clientRectangle = client;
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
        public void Init(Graphics graphics)
        {
            graphics.Clear(this.waterColor);

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
                this.random.Next(0, this.clientRectangle.Width),
                this.random.Next(0, this.clientRectangle.Height));
        }
    }
}