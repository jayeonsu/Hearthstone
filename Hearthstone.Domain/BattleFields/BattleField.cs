using System.Collections.Generic;
using Hearthstone.Domain.Cards;
using Hearthstone.Domain.Players;
using Hearthstone.Domain.Histories;



namespace Hearthstone.Domain.BattleFields
{
	class BattleField
	{
		private IHistoryStore HistoryStore { get; }
		private List<CardAbility> CardAbilitiesInEffect { get; } = new List<CardAbility>();

		public Player CurrentTurnPlayer { get; private set; }
		public Player NotCurrentTurnPlayer { get; private set; }

		public int TurnCount { get; private set; }



		public BattleField(IHistoryStore historyStore)
		{
			HistoryStore = historyStore;
			HistoryStore.NewHistoryAdded += TestCardAbilitiesInEffect;
		}



		private void TestCardAbilitiesInEffect()
		{
			var histories = HistoryStore.GetAllHistories();

			foreach (var ability in CardAbilitiesInEffect)
			{
				if (ability.OnceInvokingCondition(this, histories) && !ability.OnceInvoked)
				{
					ability.OnceInvoke(this);
					ability.OnceInvoked = true;
				}

				if (ability.EveryTurnInvokingCondition(this, histories))
				{
					ability.EveryTurnInvoke(this);
				}

				if (ability.ReleasingInvokingCondition(this, histories))
				{
					CardAbilitiesInEffect.Remove(ability);
				}
			}
		}



		public void AddNewCardAbilityInEffect(CardAbility newCardAbility)
		{
			CardAbilitiesInEffect.Add(newCardAbility);
		}



		public void ExchangeTurn()
		{
			var temp = CurrentTurnPlayer;
			CurrentTurnPlayer = NotCurrentTurnPlayer;
			NotCurrentTurnPlayer = temp;

			TurnCount++;
		}
	}
}