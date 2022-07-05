namespace CourseProject.Extensions
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
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        public static Point Nearest(this IEnumerable<Point> points, Point point)
        {
            return points
                .Select(n => new { n, distance = Math.Sqrt(Math.Pow(n.X - point.X, 2) + Math.Pow(n.Y - point.Y, 2)) })
                .OrderBy(p => p.distance)
                .First()
                .n;
        }
    }
}