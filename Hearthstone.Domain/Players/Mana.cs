namespace Hearthstone.Domain.Players
{
	class Mana
	{
		public int CurrentMana { get; private set; }
		public int MaxMana { get; private set; }



		public void IncreaseCurrentMana(int quantity)
		{
			CurrentMana += quantity;
		}



		public void DecreaseCurrentMana(int quantity)
		{
			MaxMana -= quantity;
		}



		public void IncreaseMaxMana(int quantity)
		{
			MaxMana += quantity;
		}
	}
}