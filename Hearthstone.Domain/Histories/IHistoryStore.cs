using System;
using System.Collections.Generic;
using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Histories
{
	interface IHistoryStore
	{
		event Action NewHistoryAdded;
		void AddHistory<T>(T history) where T : DomainEvent;
		List<DomainEvent> GetAllHistories();
	}
}