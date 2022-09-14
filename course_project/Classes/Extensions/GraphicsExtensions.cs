namespace CourseProject.Classes.Extensions
{
    using System.Drawing;

    /// <summary>
    /// The graphics extensions.
    /// </summary>
    internal static class GraphicsExtensions
    {
        /// <summary>
        /// The fill triangle.
        /// </summary>
        /// <param name="graphics">
        /// The graphics.
        /// </param>
        /// <param name="brush">
        /// The brush.
        /// </param>
        /// <param name="pointX">
        /// The point X.
        /// </param>
        /// <param name="pointY">
        /// The point Y.
        /// </param>
        /// <param name="pointZ">
        /// The point Z.
        /// </param>
        public static void FillTriangle(this Graphics graphics, Brush brush, Point pointX, Point pointY, Point pointZ)
        {
            graphics.FillPolygon(brush, new[] { pointX, pointY, pointZ });
        }
    }
}
