using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : FoodItems
{
	public override void UseItem()
	{
		if(Alive)
		{
			Karmas = -15;
			Calories = 0;
			Message = "You want to eat a live bear? Bold strategy, but I don't think it will pay off...";
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
