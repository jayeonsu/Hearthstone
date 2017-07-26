namespace Hearthstone.Domain.Helpers.Messaging
{
	interface IHandle<T> where T : DomainEvent
	{
		void Handle(T domainEvent);
	}
}