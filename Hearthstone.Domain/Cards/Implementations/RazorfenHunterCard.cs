using Hearthstone.Domain.Characters;
using Hearthstone.Domain.Characters.Minions.Implementations;
using Hearthstone.Domain.Players;



namespace Hearthstone.Domain.Cards.Implementations
{
	class RazorfenHunterCard : Card
	{
		public RazorfenHunterCard() :
			base("가시덩굴 사냥꾼", "<b>전투의 함성</b>: 1/1 멧돼지를 1마리 소환합니다.", 3)
		{
			CardType = CardType.Minion;
		}



		protected override CardAbility Invoke(Player cardUser, Character target)
		{
			var razorfenHunter = new RazorfenHunterMinion();
			var boar = new Boar();


			return new CardAbility
			{
				OnceInvokingCondition = (battleField, histories) =>
				{
					return true;
				},


				OnceInvoke = battleField =>
				{
					cardUser.PlaceMinion(razorfenHunter);
					cardUser.PlaceMinion(boar);
				},


				ReleasingInvokingCondition = (battleField, histories) =>
				{
					return true;
				}
			};
		}
	}
}