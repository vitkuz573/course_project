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
        /// <param name="carps">
        /// The points.
        /// </param>
        /// <param name="pike">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        public static Point Nearest(this IEnumerable<Point> carps, Point pike)
        {
            var carps_list = new List<CarpDistance>();

            foreach (var carp in carps)
            {
                carps_list.Add(new CarpDistance(carp, Math.Sqrt(Math.Pow(carp.X - pike.X, 2) + Math.Pow(carp.Y - pike.Y, 2))));
            }

            carps_list.Sort();

            var nearest_carp = carps_list[0];

            if (nearest_carp.Distance <= 100)
            {
                return nearest_carp.Coordinates;
            }

            return new Point();
        }
    }
}