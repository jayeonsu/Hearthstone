using Hearthstone.Domain.Characters;
using Hearthstone.Domain.Players;



namespace Hearthstone.Domain.Cards
{
	abstract class Card
	{
		public string Name { get; protected set; }
		public string ExplanationText { get; protected set; }
		public string FlavorText { get; protected set; }
		public int Cost { get; protected set; }
		public bool IsSecret { get; protected set; }
		public CardType CardType { get; protected set; }



		protected Card(string name, string explanationText, int cost)
		{
			Name = name;
			ExplanationText = explanationText;
			Cost = cost;
		}



		public void Use(Player cardUser, Character target)
		{
			var cardAbility = Invoke(cardUser, target);
			cardUser.BattleField.AddNewCardAbilityInEffect(cardAbility);
		}



		protected abstract CardAbility Invoke(Player cardUser, Character target);
	}
}