using System;
using System.Linq;
using Hearthstone.Domain.Players;
using Hearthstone.Domain.Characters;
using Hearthstone.Domain.Characters.Events;
using Hearthstone.Domain.Characters.Minions.Implementations;



namespace Hearthstone.Domain.Cards.Implementations
{
	class BearTrapCard : Card
	{
		public BearTrapCard() :
			base("곰 덫", "<b>비밀</b>: 내 영웅이 공격받은 후에 도발 능력이 있는 3/3 곰을 1마리 소환합니다.", 2)
		{
			CardType = CardType.Spell;
			IsSecret = true;
		}



		protected override CardAbility Invoke(Player cardUser, Character target)
		{
			var ironfurGrizzly = new IronfurGrizzlyMinion();
			var usedTime = DateTime.Now;


			return new CardAbility
			{
				OnceInvokingCondition = (battleField, histories) =>
				{
					return histories
						.Where(e => e.Created > usedTime)
						.Any(e => e.GetType() == typeof(DamagedEvent) && ((DamagedEvent)e).Character == cardUser.Hero);
				},


				OnceInvoke = battleField =>
				{
					cardUser.PlaceMinion(ironfurGrizzly);
				},


				ReleasingInvokingCondition = (battleField, histories) =>
				{
					return histories
						.Where(e => e.Created > usedTime)
						.Any(e => e.GetType() == typeof(DamagedEvent) && ((DamagedEvent)e).Character == cardUser.Hero);
				}
			};
		}
	}
}