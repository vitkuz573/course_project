namespace CourseProject.Classes
{
    using System;
    using System.Drawing;

    /// <summary>
    /// The carp distance.
    /// </summary>
    internal class CarpDistance : IComparable<CarpDistance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarpDistance"/> class.
        /// </summary>
        public CarpDistance(Point coordinates, double distance)
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

        public int CompareTo(CarpDistance other)
        {
            return Distance.CompareTo(other.Distance);
        }
    }
}
