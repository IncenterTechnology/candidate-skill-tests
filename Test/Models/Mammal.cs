using System;
using System.Collections.Generic;

namespace Test.Models
{
	public abstract class Mammal : IFoodConsumer
	{
		public virtual int EatFood(IEnumerable<IFood> food) => throw new NotImplementedException();
	}
}
