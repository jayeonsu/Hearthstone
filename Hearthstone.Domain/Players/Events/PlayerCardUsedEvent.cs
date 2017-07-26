using Hearthstone.Domain.Cards;
using Hearthstone.Domain.Characters;
using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Players.Events
{
	class PlayerCardUsedEvent : DomainEvent
	{
		public Player Player { get; set; }
		public Card Card { get; set; }
		public Character Target { get; set; }
	}
}