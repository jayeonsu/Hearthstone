using System;



namespace Hearthstone.Domain.Helpers.Messaging
{
	abstract class DomainEvent
	{
		public DateTime Created { get; } = DateTime.Now;
	}
}