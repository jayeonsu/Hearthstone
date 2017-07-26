using Hearthstone.Domain.Helpers.Messaging;
using Hearthstone.Domain.Histories;



namespace Hearthstone.Domain.EventHandlers
{
	class HistoryHandler<T> : IHandle<T> where T : DomainEvent
	{
		private IHistoryStore HistoryStore { get; }



		public HistoryHandler(IHistoryStore historyStore)
		{
			HistoryStore = historyStore;
		}



		public void Handle(T history)
		{
			HistoryStore.AddHistory(history);
		}
	}
}