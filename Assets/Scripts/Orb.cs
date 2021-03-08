using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : FoodItems
{
	public override void UseItem()
	{
		if (Alive)
		{
			Karmas = -10;
			Calories = -10;
			Message = "Uh buddy, thats a rock... But you do you.";
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
