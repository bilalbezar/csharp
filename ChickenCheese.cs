using System;

namespace Burger
{
	public class ChickenCheese: Burger
	{
		private ChickenCheese()
		{}

		public static ChickenCheese ChickenCheeseFactory()
		{
			return new ChickenCheese();
		}
		public virtual string getName()
		{
			return "\"CHICKEN CHEESE BURGER\"";
		}
		public virtual int getPrice()
		{
			return 120;
		}
		public virtual string[] getIngredients()
		{
			return new String[]{ "CHICKEN","CHEESE","BUN" };
		}
	}
}
