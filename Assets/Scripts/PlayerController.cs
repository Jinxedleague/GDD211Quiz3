using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text playerMessage;
    public Text Stats;
    public bool Alive;
    private int Intake;
    private int Karma;

    private void Awake()
    {
        Intake = 0;
        Karma = 0;
        Alive = true;
    }
    public void WriteMessage(string words)
    {
        playerMessage.text = words;
    }

    public void UpdateStats(int cals, int karm)
    {
        Intake += cals;
        Karma += karm;
        Stats.text = "Your caloric intake is " + Intake + " and your karma is " + Karma;
        if ((Intake < -30) || (Karma < -20))
        {
            Stats.text = "You Died!";
            Alive = false;
        }
    }

    public bool getLiving()
    {
        return Alive;
    }
}
