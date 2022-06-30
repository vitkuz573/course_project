﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace course_project
{
    internal static class ClsPoints
    {
        public static Point NearestPoint(this List<Point> points, Point point)
        {
            return points
                .Select(n => new { n, distance = Math.Sqrt(Math.Pow(n.X - point.X, 2) + Math.Pow(n.Y - point.Y, 2)) })
                .OrderBy(p => p.distance)
                .First()
                .n;
        }
    }
}