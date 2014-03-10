using System;

namespace TryIt
{
	public struct Point
	{
		public int X, Y;

		public Point (int x, int y)
		{
			X = x;
			Y = y;
		}

		public override bool Equals (Object two)
		{
			return X == ((Point)two).X && Y == ((Point)two).Y;
		}
		public static bool operator == (Point one, Point two)
		{
			return one.X == two.X && one.Y == two.Y;
		}
		public static bool operator != (Point one, Point two)
		{
			return one.X != two.X || one.Y != two.Y;
		}
		public override int GetHashCode()
            {
                return (X * 0x100000) + (Y * 0x1000);
            }

        public Point Up() { return new Point(X, Y - 1);}
        public Point Down() { return new Point(X, Y + 1); }
        public Point Right() { return new Point(X + 1, Y); }
        public Point Left() { return new Point(X - 1, Y); }
	}
}

