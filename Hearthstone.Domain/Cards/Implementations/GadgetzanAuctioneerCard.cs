using System;
using System.Linq;
using Hearthstone.Domain.Players;
using Hearthstone.Domain.Players.Events;
using Hearthstone.Domain.Characters;
using Hearthstone.Domain.Characters.Events;
using Hearthstone.Domain.Characters.Minions.Implementations;



namespace Hearthstone.Domain.Cards.Implementations
{
	class GadgetzanAuctioneerCard : Card
	{
		public GadgetzanAuctioneerCard() :
			base("가젯잔 경매인", "내가 주문을 시전할 때마다 카드를 1장 뽑습니다.", 6)
		{
			CardType = CardType.Minion;
		}



		protected override CardAbility Invoke(Player cardUser, Character target)
		{
			var gadgetzanAuctioneer = new GadgetzanAuctioneerMinion();
			var usedTime = DateTime.Now;


			return new CardAbility
			{
				OnceInvokingCondition = (battleField, histories) =>
				{
					return true;
				},


				OnceInvoke = b =>
				{
					cardUser.PlaceMinion(gadgetzanAuctioneer);
				},


				EveryTurnInvokingCondition = (battleField, histories) =>
				{
					var lastHistory = histories.Last();

					if (lastHistory is PlayerCardUsedEvent)
					{
						var lastCardUsedHistory = lastHistory as PlayerCardUsedEvent;

						return lastCardUsedHistory.Player == cardUser &&
							   lastCardUsedHistory.Card.CardType == CardType.Spell;
					}

					return false;
				},


				EveryTurnInvoke = battleField =>
				{
					cardUser.DrawCard();
				},


				ReleasingInvokingCondition = (battleField, histories) =>
				{
					return histories
						.Where(e => e.Created > usedTime && e.GetType() == typeof(DiedEvent))
						.Any(e => (e as DiedEvent).Character == gadgetzanAuctioneer);
				},


				ReleasingInvoke = battleField =>
				{
				}
			};
		}
	}
}