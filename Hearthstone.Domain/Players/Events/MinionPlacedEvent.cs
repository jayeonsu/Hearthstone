using Hearthstone.Domain.Characters.Minions;
using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Players.Events
{
	class MinionPlacedEvent : DomainEvent
	{
		public Player Player { get; set; }
		public Minion Minion { get; set; }
		public int PositionIndex { get; set; }
	}
}