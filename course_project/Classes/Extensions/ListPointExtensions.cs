namespace CourseProject.Classes.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

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
            List<Carps> carps = new List<Carps>();

            foreach (var carp in points)
            {
                carps.Add(new Carps(carp, Math.Sqrt(Math.Pow(carp.X - point.X, 2) + Math.Pow(carp.Y - point.Y, 2))));
            }

            carps.Sort();

            var nearest_carp = carps[0];

            if (nearest_carp.Distance <= 100)
            {
                return nearest_carp.Coordinates;
            }

            return new Point();
        }
    }
}