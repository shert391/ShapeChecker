using System;

namespace ShapeChecker
{
    internal static class SegmentManager
    {
        private static double CalculatePseudoscalarVectors(Vector one, Vector two)
        {
            return one.X * two.Y - two.X * one.Y;
        }
        public static bool IsIntersect(Segment one, Segment two) // проверяет , пересекаются-ли отрезки
        {
            Vector vectorOne = new Vector(one.PointTwo.X - one.PointOne.X, one.PointTwo.Y - one.PointOne.Y);
            Vector vectorTwo = new Vector(two.PointOne.X - one.PointOne.X, two.PointOne.Y - one.PointOne.Y);
            Vector vectorThree = new Vector(two.PointTwo.X - one.PointOne.X, two.PointTwo.Y - one.PointOne.Y);

            double resPseudoOne = CalculatePseudoscalarVectors(vectorOne, vectorTwo);
            double resPseudoTwo = CalculatePseudoscalarVectors(vectorOne, vectorThree);

            if (resPseudoOne > 0 && resPseudoTwo < 0 || resPseudoOne < 0 && resPseudoTwo > 0)
            {
                vectorOne = new Vector(two.PointTwo.X - two.PointOne.X, two.PointTwo.Y - two.PointOne.Y);
                vectorTwo = new Vector(one.PointOne.X - two.PointOne.X, one.PointOne.Y - two.PointOne.Y);
                vectorThree = new Vector(one.PointTwo.X - two.PointOne.X, one.PointTwo.Y - two.PointOne.Y);

                double resPseudoThree = CalculatePseudoscalarVectors(vectorOne, vectorTwo);
                double resPseudoFour = CalculatePseudoscalarVectors(vectorOne, vectorThree);

                if (resPseudoThree >= 0 && resPseudoFour < 0 || resPseudoThree < 0 && resPseudoFour >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool LiesOnTheSegment(Segment seg, Point point) // проверяем лежит-ли точка на отрезке
        {
            if (Math.Round((point.X - seg.PointOne.X) * (seg.PointTwo.Y - seg.PointOne.Y), 2) == Math.Round((seg.PointTwo.X - seg.PointOne.X) * (point.Y - seg.PointOne.Y), 2))
            {
                if ((0 <= (point.X - seg.PointOne.X) * (seg.PointTwo.X - point.X)) && ((point.X - seg.PointOne.X) * (seg.PointTwo.X - point.X) <= Math.Pow(seg.PointOne.X - seg.PointTwo.X, 2.0)))
                {
                    if ((0 <= (point.Y - seg.PointOne.Y) * (seg.PointTwo.Y - point.Y)) && ((point.Y - seg.PointOne.Y) * (seg.PointTwo.Y - point.Y) <= Math.Pow(seg.PointOne.Y - seg.PointTwo.Y, 2.0)))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
