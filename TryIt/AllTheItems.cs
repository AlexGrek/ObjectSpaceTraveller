using System;
using System.Collections.Generic;

namespace TryIt
{
	[Serializable]
	public static class AllTheItems {
		public static List<Weapon> Weapons = new List<Weapon>();
		public static List<Shield> Shields = new List<Shield>();

		static AllTheItems ()
		{
			#region Weapons
			Weapons.Add(new Weapon("PM-03 Slingshot", DamageType.Photon, 20, 150, 1, 100));
			Weapons.Add(new Weapon("Moonbeam v1", DamageType.Laser, 50, 300, 2, 85));
			Weapons.Add(new Weapon("Doomsday", DamageType.Plasma, 1000, 8000, 10, 2));
			Weapons.Add(new Weapon("M666 Love Missle", DamageType.Rocket, 666, 6666, 3, 19));
			Weapons.Add(new Weapon("PM-07 Mangonel", DamageType.Photon, 100, 500, 2, 89));
			#endregion

			#region Shields
			var newShield = new Shield ("Diaper", 50, 1, 90) {
				Laser = 22,
				Plasma = 14,
				Photon = 12,
				Rocket = 18 };
			Shields.Add(newShield);

			newShield = new Shield ("Power Cover F2000", 100, 2, 45) {
				Laser = 18,
				Plasma = 19,
				Photon = 34,
				Rocket = 17 };
			Shields.Add(newShield);

			newShield = new Shield ("F4 Faith", 1000, 1, 22) {
				Laser = 48,
				Plasma = 24,
				Photon = 32,
				Rocket = 31 };
			Shields.Add(newShield);

			newShield = new Shield ("The Blessing", 4000, 2, 2) {
				Laser = 90,
				Plasma = 75,
				Photon = 49,
				Rocket = 63 };
			Shields.Add(newShield);
			#endregion
		}
	}
}

