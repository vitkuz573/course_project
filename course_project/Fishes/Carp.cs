namespace CourseProject.Fishes
{
    using System.Drawing;

    using CourseProject.Properties;

    /// <summary>
    /// The carp.
    /// </summary>
    internal class Carp : Fish
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carp"/> class.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public Carp(Point data)
        {
            this.Data = data;

            this.FishSize = new Size(40, 40);

            this.FishImage = this.FishSpeedWidth < 0 ? Resources.carp_to_left : Resources.carp_to_right;
        }

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        public Carp Next { get; set; }

        /// <summary>
        /// The draw.
        /// </summary>
        /// <param name="graphics">
        /// The graphics.
        /// </param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(this.FishImage, this.Data.X, this.Data.Y, this.FishSize.Width, this.FishSize.Height);
        }
    }
}