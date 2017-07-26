using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Players.Events
{
	class PlayerTurnEndedEvent : DomainEvent
	{
		public Player Player { get; set; }
	}
}