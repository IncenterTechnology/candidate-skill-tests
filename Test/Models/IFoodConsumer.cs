using System.Collections.Generic;

namespace Test.Models
{
	public interface IFoodConsumer
	{
		int EatFood(IEnumerable<IFood> food);
	}
}
