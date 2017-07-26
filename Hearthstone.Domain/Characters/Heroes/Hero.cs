using Hearthstone.Domain.Characters.Heroes.HeroPowers;
using Hearthstone.Domain.Characters.Heroes.Weapons;



namespace Hearthstone.Domain.Characters.Heroes
{
	class Hero : Character
	{
		public HeroPower HeroPower { get; protected set; }
		public Weapon Weapon { get; protected set; }



		public Hero(string name, int attackPoint, Health health, HeroPower heroPower)
			: base(name, attackPoint, health)
		{
			HeroPower = heroPower;
		}
	}
}