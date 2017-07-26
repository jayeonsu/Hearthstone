using System;
using System.Collections.Generic;
using Hearthstone.Domain.Helpers.Messaging;
using Hearthstone.Domain.BattleFields;



namespace Hearthstone.Domain.Cards
{
	class CardAbility
	{
		public bool OnceInvoked { get; set; }
		public Func<BattleField, IEnumerable<DomainEvent>, bool> OnceInvokingCondition { get; set; }
		public Action<BattleField> OnceInvoke { get; set; }

		public Func<BattleField, IEnumerable<DomainEvent>, bool> EveryTurnInvokingCondition { get; set; }
		public Action<BattleField> EveryTurnInvoke { get; set; }

		public Func<BattleField, IEnumerable<DomainEvent>, bool> ReleasingInvokingCondition { get; set; }
		public Action<BattleField> ReleasingInvoke { get; set; }
	}
}