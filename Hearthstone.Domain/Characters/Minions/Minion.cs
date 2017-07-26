using Hearthstone.Domain.Helpers.Messaging;
using Hearthstone.Domain.Characters.Minions.Events;



namespace Hearthstone.Domain.Characters.Minions
{
	abstract class Minion : Character
	{
		public bool HasDivineShield { get; protected set; }
		public bool IsTaunt { get; protected set; }
		public bool IsCharge { get; protected set; }
		public bool IsStealth { get; protected set; }
		public bool IsSilenced { get; protected set; }



		protected Minion(string name, int attackPoint, Health health)
			: base(name, attackPoint, health)
		{
		}



		public void AttachDivineShield()
		{
			HasDivineShield = true;
			DomainEvents.Raise(new DivineShieldAttachedEvent());
		}



		public void UnattachDivineShield()
		{
			HasDivineShield = false;
			DomainEvents.Raise(new DivineShieldUnattachedEvent());
		}



		//
		//
		//
	}
}