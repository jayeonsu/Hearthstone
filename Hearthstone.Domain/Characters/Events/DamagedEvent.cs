using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Characters.Events
{
	class DamagedEvent : DomainEvent
	{
		public Character Character { get; set; }
		public int DamagePoint { get; set; }
	}
}