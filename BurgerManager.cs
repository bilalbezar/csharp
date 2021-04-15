using System;

namespace Burger
{
	public class BurgerManager
	{
		public static Burger getBurger( string str )
		{
			if(str.Equals("CHICKEN"))
			{
				return ChickenCheese.ChickenCheeseFactory();
			}
			if(str.Equals("BEEF"))
			{
				return BeefBurger.BeefBurgerFactory();
			}
			if(str.Equals("FISH"))
			{
				return FishBurger.FishBurgerFactory();
			}
			return null;
		}
	}
}
