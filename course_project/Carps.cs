namespace CourseProject
{
    using System;
    using System.Drawing;

    /// <summary>
    /// The carps.
    /// </summary>
    internal class Carps : IComparable<Carps>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carps"/> class.
        /// </summary>
        public Carps(Point coordinates, double distance)
        {
            Coordinates = coordinates;
            Distance = distance;
        }

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        public Point Coordinates { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        public double Distance { get; set; }

        public int CompareTo(Carps other)
        {
            return Distance.CompareTo(other.Distance);
        }
    }
}
