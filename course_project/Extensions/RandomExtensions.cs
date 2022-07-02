namespace CourseProject.Extensions
{
    using System;
    using System.Linq;

    /// <summary>
    /// The random extensions.
    /// </summary>
    internal static class RandomExtensions
    {
        /// <summary>
        /// The next with exclude.
        /// </summary>
        /// <param name="random">
        /// The random.
        /// </param>
        /// <param name="min">
        /// The min.
        /// </param>
        /// <param name="max">
        /// The max.
        /// </param>
        /// <param name="exclude">
        /// The exclude.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int NextWithExclude(this Random random, int min, int max, int[] exclude)
        {
            int result;

            do
            {
                result = random.Next(min, max);
            }
            while (exclude.Contains(result));

            return result;
        }
    }
}