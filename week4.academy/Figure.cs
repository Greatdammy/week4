using System;

namespace week4.academy
{
    public class Figure
    {
        public int X { get; set; }

        public static Figure operator +(Figure left, Figure right)
        {
            var f = new Figure()
            {
                X = left.X + right.X,
            };
            return f;
        }

        public static Figure operator -(Figure left, Figure right)
        {
            var f = new Figure()
            {
                X = left.X - right.X,
            };
            return f;
        }

        public static Figure operator ++(Figure left)
        {
            var f = new Figure()
            {
                X = left.X + 1
            };
            return f;
        }

        public static bool operator ==(Figure left, Figure right)
        {
            return left.X == right.X;
        }
        public static bool operator !=(Figure left, Figure right)
        {
            return left.X != right.X;
        }

        public static bool operator <=(Figure left, Figure right)
        {
            return left.X <= right.X;
        }

        public static bool operator >=(Figure left, Figure right)
        {              
            return left.X >= right.X;
        }
    }
    }

      