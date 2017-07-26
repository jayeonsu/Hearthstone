namespace Hearthstone.Domain.Characters
{
	class Health
	{
		public int CurrentHealthPoint { get; private set; }
		public int MaxHealthPoint { get; private set; }



		public Health(int initialHealthPoint)
		{
			CurrentHealthPoint = initialHealthPoint;
			MaxHealthPoint = initialHealthPoint;
		}



		public void IncreaseCurrentHealth(int point)
		{
			CurrentHealthPoint += point;
		}



		public void DecreaseCurrentHealth(int point)
		{
			CurrentHealthPoint -= point;
		}
	}
}