namespace Hearthstone.Domain.Helpers.Messaging
{
	static class DomainEvents
	{
		public static void Raise<T>(T domainEvent) where T : DomainEvent
		{
		}
	}
}