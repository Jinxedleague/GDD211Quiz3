using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItems : MonoBehaviour
{
	public int Calories;
	public int Karmas;
	public bool Alive;
	public string Message;

	private void Update()
	{
		Alive = FindObjectOfType<PlayerController>().getLiving();
	}
	private void OnMouseDown()
	{
		UseItem();
	}
	public virtual void UseItem()
	{
		//two lines below find a script called TellPlayer and call functions in it
		FindObjectOfType<PlayerController>().WriteMessage(Message);
		FindObjectOfType<PlayerController>().UpdateStats(Calories, Karmas);
	}
}
