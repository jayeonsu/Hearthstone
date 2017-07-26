namespace Hearthstone.Domain.Characters.Minions.Implementations
{
	class Boar : Minion
	{
		public Boar()
			: base("멧돼지", 4, new Health(2))
		{
			IsCharge = true;
		}
	}
}