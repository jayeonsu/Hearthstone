using Hearthstone.Domain.Players;
using Hearthstone.Domain.Characters;



namespace Hearthstone.Domain.Cards.Implementations
{
	class FireballCard : Card
	{
		public FireballCard() :
			base("화염구", "피해를 6 줍니다.", 4)
		{
			CardType = CardType.Spell;
		}



		protected override CardAbility Invoke(Player cardUser, Character target)
		{
			return new CardAbility
			{
				OnceInvokingCondition = (battleField, histories) =>
				{
					return true;
				},

				OnceInvoke = battleField =>
				{
					target.Damage(6);
				},


				ReleasingInvokingCondition = (battleField, histories) =>
				{
					return true;
				}
			};
		}
	}
}