using System;
using System.Linq;

namespace course_project
{
    internal static class ClsRandom
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