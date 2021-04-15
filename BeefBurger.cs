using System;

namespace Burger
{
	public class BeefBurger: Burger
	{
		private BeefBurger()
		{}

		public static BeefBurger BeefBurgerFactory()
		{
			return new BeefBurger();
		}
		public virtual string getName()
		{
			return "\"BEEF BURGER\"";
		}
		public virtual int getPrice()
		{
			return 100;
		}
		public virtual string[] getIngredients()
		{
			return new String[]{ "BEEF","SALAD","BUN" };
		}
	}
}
