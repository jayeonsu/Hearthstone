using Hearthstone.Domain.Cards;
using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Players.Events
{
	class PlayerCardDrawnEvent : DomainEvent
	{
		public Player Player { get; set; }
		public Card Card { get; set; }
	}
}