using System.Collections.Generic;

namespace ShapeChecker
{
    internal static class ShapeManager
    {
        public static bool LiesOnTheSide(List<Segment> shape, Point point) // проверяем , принадлежит-ли точка стороне многоугольника
        {
            for (int i = 0; i < shape.Count; i++)
            {
                if (SegmentManager.LiesOnTheSegment(shape[i], point))
                    return true;
                else
                    continue;
            }
            return false;
        }
        public static bool LiesInside(List<Segment> shape, Point point) // проверяем , точка лежит внутри или снаружи 
        {
            double max = shape[0].PointOne.X;

            for (int i = 0; i < shape.Count; i++) // нахожу максимальную точку абциссы 
            {
                if (shape[i].PointOne.X > max)
                    max = shape[i].PointOne.X;
                if (shape[i].PointTwo.X > max)
                    max = shape[i].PointTwo.X;
            }
            max += 2;

            Segment checkingSegment = new Segment(point, new Point(max, point.Y));

            int countIntersections = 0;

            for (int i = 0; i < shape.Count; i++)
            {
                if (SegmentManager.IsIntersect(checkingSegment, shape[i]))
                    countIntersections++;
                else
                    continue;
            }

            if (countIntersections % 2 == 0)
                return false;
            else
                return true;
        }
    }
}
