using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beehive : FoodItems
{
	public override void UseItem()
	{
		if (Alive)
		{
			Karmas = -10;
			Calories = 20;
			Message = "Honey is very healthy, but the bees are very angry!";
			base.UseItem();
		}
		else
		{
			Karmas = 0;
			Calories = 0;
			Message = "You're already dead!";
			base.UseItem();
		}
	}
}
