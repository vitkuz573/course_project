namespace CourseProject.Fishes
{
    using System.Drawing;

    using CourseProject.Properties;

    /// <summary>
    /// The pike.
    /// </summary>
    internal class Pike : Fish
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pike"/> class.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public Pike(Point data)
        {
            this.Data = data;

            this.FishSize = new Size(80, 80);

            this.FishImage = this.FishSpeedWidth < 0 ? Resources.pike_to_left : Resources.pike_to_right;
        }

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        public Pike Next { get; set; }

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