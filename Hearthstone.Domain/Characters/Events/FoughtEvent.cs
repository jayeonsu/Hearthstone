using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Characters.Events
{
	class FoughtEvent : DomainEvent
	{
		public Character Attacker { get; set; }
		public Character Attackee { get; set; }
	}
}