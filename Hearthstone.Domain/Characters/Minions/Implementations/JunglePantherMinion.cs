namespace Hearthstone.Domain.Characters.Minions.Implementations
{
	class JunglePantherMinion : Minion
	{
		public JunglePantherMinion()
			: base("밀림 표범", 4, new Health(2))
		{
			IsStealth = true;
		}
	}
}