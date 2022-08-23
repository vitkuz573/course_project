namespace CourseProject.Classes.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    /// <summary>
    /// The list point extensions.
    /// </summary>
    internal static class ListPointExtensions
    {
        /// <summary>
        /// The nearest.
        /// </summary>
        /// <param name="carps">
        /// The carps.
        /// </param>
        /// <param name="pike">
        /// The pike.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        public static Point Nearest(this IEnumerable<Point> carps, Point pike)
        {
            var nearest_carp = carps
                .Select(coordinates => new { coordinates, distance = Math.Sqrt(Math.Pow(coordinates.X - pike.X, 2) + Math.Pow(coordinates.Y - pike.Y, 2)) })
                .OrderBy(p => p.distance)
                .First();

            if (nearest_carp.distance <= 100)
            {
                return nearest_carp.coordinates;
            }

            return new Point();
        }
    }
}