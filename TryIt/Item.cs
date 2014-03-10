using System;

namespace TryIt
{
	public class Item
	{
		public string Name;
		protected internal int _cost;
		protected internal int _weight;
	    protected short _rarity;

		public Item (string name, int cost, int weight, short rarity)
		{
			Name = name;
			_cost = cost;
			_weight = weight;
		    _rarity = rarity;
		}

		public Item ()
		{
		    
		}

	    public int Cost {
			get {
				return _cost;
			}
		}		
		public int Weight {
			get {
				return _weight;
			}
		}
		public virtual string Description {
			get {return ToString();}
		}

	    public int Rarity
	    {
	        get { return _rarity; }
	    }
	}

	public enum DamageType {Rocket, Laser, Plasma, Photon};

	public class Weapon : Item
	{
	    readonly int _damage;
	    readonly DamageType _type;

		public Weapon (string name, DamageType type, int damage, int cost, int weight, short rarity) {
			_damage = damage;
			Name = name;
			_type = type;
			_cost = cost;
			_weight = weight;
		    _rarity = rarity;
		}

		public DamageType Type {get {return _type;} }
		public int Damage { get {return _damage;} }
		public override string Description {
			get { return "Weapon. Deals " + _damage.ToString() + " points of " +
				_type.ToString() + " damage.";}
		}
	}

	public class Shield : Item
	{
		public int Rocket, Laser, Plasma, Photon;

		public Shield (string name, int cost, int weight, short rarity)
		{
			Name = name;
			_cost = cost;
			_weight = weight;
		    _rarity = rarity;
		}

		public override string Description {
			get { return "Shield. Local protection level: Rocket: " + Rocket.ToString() + 
				", Laser: " + Laser.ToString() + ", Plasma: " + Plasma.ToString() + 
					", Photon: " + Photon.ToString(); }
		}
	}
}

