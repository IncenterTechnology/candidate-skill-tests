using System;

namespace Test.Models
{
	public abstract class Food : IFood
	{
		public Food(FoodType type)
		{
			Type = type;
		}
		public virtual int Calories => throw new NotImplementedException();
		public FoodType Type { get; private set; }
	}
}
