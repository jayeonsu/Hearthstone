namespace Hearthstone.Domain.Characters.Minions.Implementations
{
	class IronfurGrizzlyMinion : Minion
	{
		public IronfurGrizzlyMinion()
			: base("무쇠가죽 불곰", 3, new Health(3))
		{
			IsTaunt = true;
		}
	}
}