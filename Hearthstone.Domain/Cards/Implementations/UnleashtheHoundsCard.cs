using Hearthstone.Domain.Players;
using Hearthstone.Domain.Characters;
using Hearthstone.Domain.Characters.Minions.Implementations;



namespace Hearthstone.Domain.Cards.Implementations
{
	class UnleashTheHoundsCard : Card
	{
		public UnleashTheHoundsCard() :
			base("개들을 풀어라", "적 하수인 하나당 돌진 능력이 있는 1/1 사냥개를 1마리씩 소환합니다.", 3)
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
				

				OnceInvoke = (battleField) =>
				{
					var minionCountOfOppenent = battleField.NotCurrentTurnPlayer.Minions.Count;

					for (var i = 0; i < minionCountOfOppenent; i++)
					{
						var hound = new HoundMinion();
						cardUser.PlaceMinion(hound);
					}
				},


				ReleasingInvokingCondition = (battleField, histories) =>
				{
					return true;
				}
			};
		}
	}
}