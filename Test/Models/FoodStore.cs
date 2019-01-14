using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Models
{
	public class FoodStore
	{
		IList<IFoodProvider> _providers = new List<IFoodProvider>();
		public void AddProvider(IFoodProvider provider)
		{
			if (provider == null)
			{
				throw new NullReferenceException("Provider can't be null");
			}

			_providers.Add(provider);
		}

		public IEnumerable<IFood> BuyFood(FoodType type, int count)
		{
			if (count == 0)
				return null;

			var provider = _providers.FirstOrDefault(p => p.Type == type);
			if (provider == null)
				return null;

			return provider.GetFood(count);
		}
	}
}
