using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Characters.Events
{
	class UnfreezedEvent : DomainEvent
	{
		public Character Character { get; set; }
	}
}