using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Characters.Events
{
	class HealedEvent : DomainEvent
	{
		public Character Character { get; set; }
		public int HealPoint { get; set; }
	}
}