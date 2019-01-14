using System.Collections.Generic;

namespace Test.Models
{
	public interface IFoodProvider
	{
		FoodType Type { get; }
		IEnumerable<IFood> GetFood(int count);
	}
}
