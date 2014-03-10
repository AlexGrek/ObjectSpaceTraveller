using System;
using System.Collections;

namespace TryIt
{
	public class Player
	{
	    private Point _position;

	    public Point Position
	    {
	        get { return _position; }
	        set { _position = value; }
	    }

	    public Player (Point start)
		{
			Position = start;
		}

	    public void Move(Dir direction)
	    {
	        switch (direction)
	        {
	            case Dir.Down:
	                _position.Y++;
	                return;
                case Dir.Up:
	                _position.Y--;
	                return;
                case Dir.Left:
	                _position.X--;
	                return;
                case Dir.Right:
	                _position.X++;
	                return;
                default:
	                return;
	        }
	    }
	}
}

