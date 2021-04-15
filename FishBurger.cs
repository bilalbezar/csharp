using System;

namespace Burger
{
	public class FishBurger: Burger
	{
		private FishBurger()
		{}

		public static FishBurger FishBurgerFactory()
		{
			return new FishBurger();
		}
		public virtual string getName()
		{
			return "\"FISH BURGER\"";
		}
		public virtual int getPrice()
		{
			return 150;
		}
		public virtual string[] getIngredients()
		{
			return new String[]{ "FISH","SALAD","BUN" };
		}
	}
}
