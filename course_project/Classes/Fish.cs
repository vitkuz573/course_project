namespace CourseProject.Classes
{
    using System.Drawing;

    using CourseProject.Classes.Extensions;

    /// <summary>
    /// The fish.
    /// </summary>
    public abstract class Fish
    {
        /// <summary>
        /// The speed.
        /// </summary>
        private Size speed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fish"/> class.
        /// </summary>
        protected Fish()
        {
            this.speed = new Size(
                Aquarium.AquariumRandom.NextWithExclude(-5, 5, new[] { -1, 0, 1 }),
                Aquarium.AquariumRandom.NextWithExclude(-5, 5, new[] { -1, 0, 1 }));
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public Point Data { get; protected set; }

        /// <summary>
        /// Gets or sets the fish image.
        /// </summary>
        protected Image FishImage { get; set; }

        /// <summary>
        /// Gets or sets the fish size.
        /// </summary>
        protected Size FishSize { get; set; }

        /// <summary>
        /// Gets the fish speed width.
        /// </summary>
        protected int FishSpeedWidth
        {
            get => this.speed.Width;
            private set => this.speed.Width = value;
        }

        /// <summary>
        /// Gets or sets the fish speed height.
        /// </summary>
        private int FishSpeedHeight
        {
            get => this.speed.Height;
            set => this.speed.Height = value;
        }

        /// <summary>
        /// The draw.
        /// </summary>
        /// <param name="graphics">
        /// The graphics.
        /// </param>
        public abstract void Draw(Graphics graphics);

        /// <summary>
        /// The update location.
        /// </summary>
        /// <param name="bounds">
        /// The bounds.
        /// </param>
        public void UpdateLocation(Rectangle bounds)
        {
            if (!bounds.Contains(this.Data + this.speed))
            {
                if (this.Data.X + this.FishSpeedWidth < bounds.Left
                    || this.Data.X + this.FishSpeedWidth > bounds.Right - this.FishSize.Width)
                {
                    this.FishSpeedWidth *= -1;
                    this.FishImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                }

                if (this.Data.Y + this.FishSpeedHeight < bounds.Top
                    || this.Data.Y + this.FishSpeedHeight > bounds.Bottom - this.FishSize.Height)
                {
                    this.FishSpeedHeight *= -1;
                }
            }

            this.Data += this.speed;
        }
    }
}