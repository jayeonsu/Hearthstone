using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Characters.Minions.Events
{
	class DivineShieldAttachedEvent : DomainEvent
	{
		public Minion Minion { get; set; }
	}
}