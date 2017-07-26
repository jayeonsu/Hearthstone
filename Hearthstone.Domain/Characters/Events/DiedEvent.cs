using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Characters.Events
{
	class DiedEvent : DomainEvent
	{
		public Character Character { get; set; }
	}
}