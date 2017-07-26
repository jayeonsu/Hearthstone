using Hearthstone.Domain.BattleFields;
using Hearthstone.Domain.Helpers.Messaging;
using Hearthstone.Domain.Players.Events;



namespace Hearthstone.Domain.EventHandlers
{
	class PlayerEventHandler
		: IHandle<PlayerTurnEndedEvent>
	{
		private BattleField BattleField { get; }



		public PlayerEventHandler(BattleField battleField)
		{
			BattleField = battleField;
		}



		public void Handle(PlayerTurnEndedEvent history)
		{
			BattleField.ExchangeTurn();
		}
	}
}