using System;
using System.Collections.Generic;
using Hearthstone.Domain.Helpers.Messaging;



namespace Hearthstone.Domain.Histories
{
	class HistoryStore : IHistoryStore
	{
		private List<DomainEvent> Histories { get; } = new List<DomainEvent>();
		public event Action NewHistoryAdded;



		public void AddHistory<T>(T history) where T : DomainEvent
		{
			Histories.Add(history);
			NewHistoryAdded?.Invoke();
		}



		public List<DomainEvent> GetAllHistories()
		{
			return Histories;
		}
	}
}