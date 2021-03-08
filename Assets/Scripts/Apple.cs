using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : FoodItems
{
	public override void UseItem()
	{
		if (Alive)
		{
			Karmas = 10;
			Calories = 15;
			Message = "Apples are a great source of nutrition!";
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
