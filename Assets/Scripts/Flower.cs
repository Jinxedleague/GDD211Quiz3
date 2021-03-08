using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : FoodItems
{
	public override void UseItem()
	{
		if (Alive)
		{
			Karmas = 10;
			Calories = -5;
			Message = "Interesting choice, but that flower isn't food";
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
