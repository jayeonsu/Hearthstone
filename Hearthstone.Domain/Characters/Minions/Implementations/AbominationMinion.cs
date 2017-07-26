namespace Hearthstone.Domain.Characters.Minions.Implementations
{
	class AbominationMinion : Minion
	{
		public AbominationMinion()
			: base("누더기골렘", 4, new Health(4))
		{
			IsTaunt = true;
		}
	}
}