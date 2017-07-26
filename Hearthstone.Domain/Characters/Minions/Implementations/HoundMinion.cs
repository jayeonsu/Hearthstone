namespace Hearthstone.Domain.Characters.Minions.Implementations
{
	class HoundMinion : Minion
	{
		public HoundMinion()
			: base("사냥개", 1, new Health(1))
		{
			IsCharge = true;
		}
	}
}