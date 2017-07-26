using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Characters.Minions.Events
{
	class DivineShieldUnattachedEvent : DomainEvent
	{
		public Minion Minion { get; set; }
	}
}