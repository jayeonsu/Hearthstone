using System.Collections.Generic;
using Hearthstone.Domain.Helpers.Messaging;
using Hearthstone.Domain.BattleFields;
using Hearthstone.Domain.Cards;
using Hearthstone.Domain.Characters;
using Hearthstone.Domain.Characters.Heroes;
using Hearthstone.Domain.Characters.Minions;
using Hearthstone.Domain.Players.Events;



namespace Hearthstone.Domain.Players
{
	class Player
	{
		public BattleField BattleField { get; }
		public string PlayerName { get; }
		public Mana Mana { get; } = new Mana();
		public Hero Hero { get; }
		public List<Minion> Minions { get; } = new List<Minion>();
		public Queue<Card> Deck { get; }
		public List<Card> Hand { get; } = new List<Card>();



		public Player(BattleField battleField, string playerName, Hero hero, Queue<Card> deck)
		{
			BattleField = battleField;
			PlayerName = playerName;
			Hero = hero;
			Deck = deck;
		}



		public void DrawCard()
		{
			var drawingCard = Deck.Dequeue();
			Hand.Add(drawingCard);

			DomainEvents.Raise(new PlayerCardDrawnEvent { Player = this, Card = drawingCard });
		}



		public void UseCard(Card card, Character target)
		{
			Mana.DecreaseCurrentMana(card.Cost);

			card.Use(this, target);

			Hand.Remove(card);

			DomainEvents.Raise(new PlayerCardUsedEvent { Player = this, Card = card, Target = target });
		}



		public void PlaceMinion(Minion minion)
		{
			Minions.Add(minion);
			DomainEvents.Raise(new MinionPlacedEvent());
		}



		public void EndTurn()
		{
			DomainEvents.Raise(new PlayerTurnEndedEvent { Player = this });
		}
	}
}