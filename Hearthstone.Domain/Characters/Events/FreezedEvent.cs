using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Characters.Events
{
	class FreezedEvent : DomainEvent
	{
		public Character Character { get; set; }
	}
}