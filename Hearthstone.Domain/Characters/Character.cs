using Hearthstone.Domain.Helpers.Messaging;
using Hearthstone.Domain.Characters.Events;



namespace Hearthstone.Domain.Characters
{
	abstract class Character
	{
		public string Name { get; protected set; }
		public int AttackPoint { get; protected set; }
		public Health Health { get; protected set; }

		public bool IsTargetableBySpell { get; protected set; } = true;
		public bool IsTargetableByCharacter { get; protected set; } = true;

		public bool IsFreezed { get; protected set; }



		protected Character(string name, int attackPoint, Health health)
		{
			Name = name;
			AttackPoint = attackPoint;
			Health = health;
		}



		public void Fight(Character target)
		{
			target.Damage(AttackPoint);
			this.Damage(target.AttackPoint);

			DomainEvents.Raise(new FoughtEvent { Attacker = this, Attackee = target });
		}



		public void Damage(int damagePoint)
		{
			Health.DecreaseCurrentHealth(damagePoint);
			DomainEvents.Raise(new DamagedEvent { Character = this, DamagePoint = damagePoint });
		}



		public void Heal(int healPoint)
		{
			Health.IncreaseCurrentHealth(healPoint);
			DomainEvents.Raise(new HealedEvent { Character = this, HealPoint = healPoint });
		}



		public void Freeze()
		{
			IsFreezed = true;
			DomainEvents.Raise(new FreezedEvent { Character = this });
		}



		public void Unfreeze()
		{
			IsFreezed = false;
			DomainEvents.Raise(new UnfreezedEvent { Character = this });
		}
	}
}