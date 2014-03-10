using System;
using System.Collections.Generic;
using System.Collections;

namespace TryIt
{
    public enum ShipClass {Trader, Battleship,  }

	public class Ship
	{
        private readonly short _gunPlace;
	    private readonly int _armor;
	    private readonly string _name;
	    private readonly ShipClass _class;
	    public ArrayList Cargo;

	    public Ship (string name, int armor, short gunPlace, ShipClass shipClass,  Item[] args)
		{
		    _armor = armor;
		    _gunPlace = gunPlace;
	        _class = shipClass;
	        _name = name;
	        Cargo.AddRange(args);
		}

	    public short GunPlace
	    {
	        get { return _gunPlace; }
	    }

	    public int Armor
	    {
	        get { return _armor; }
	    }

	    public string Name
	    {
	        get { return _name; }
	    }

	    public Weapon MainGun { get; set; }
        public Shield Shield { get; set; }

	    public ShipClass Class
	    {
	        get { return _class; }
	    }
	}
}

