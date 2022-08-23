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
        /// <param name="points">
        /// The points.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="minDistance">
        /// The minimal distance.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        public static Point Nearest(this IEnumerable<Point> points, Point point, double minDistance)
        {
            var nearestPoint = points
                .Select(coordinates => new { coordinates, distance = Math.Sqrt(Math.Pow(coordinates.X - point.X, 2) + Math.Pow(coordinates.Y - point.Y, 2)) })
                .OrderBy(p => p.distance)
                .First();

            return nearestPoint.distance <= minDistance ? nearestPoint.coordinates : new Point();
        }
    }
}