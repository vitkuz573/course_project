using System;
using System.Linq;

namespace course_project.Extensions
{
    internal static class RandomExtensions
    {
        public static int NextWithExclude(this Random random, int min, int max, int[] exclude)
        {
            int result;

            do
            {
                result = random.Next(min, max);
            } while (exclude.Contains(result));

            return result;
        }
    }
}