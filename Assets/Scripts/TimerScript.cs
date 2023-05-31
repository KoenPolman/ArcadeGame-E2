using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float timeValue = 60; // zorgt dat de timer op 60 seconden word gezet
    public Text timeText; // de timevalue word omgezet naar text
    void Update()
    {
        if (timeValue > 0) //als de tijd groter is dan nul
        {
            timeValue -= Time.deltaTime; // blijft de tijd aftellen totdat deze op de 0 is
        }
        else
        {
            SceneManager.LoadScene(1); // dit is voor de buildsettings dat deze 2 omhoog gaan vanaf de huidige scene
            Debug.Log("Werkt");
        }
        DisplayTime(timeValue); //laat de timevalue zien op het scherm (hoeveel tijd je nog over hebt)
    }
    void DisplayTime(float timeToDisplay) //een void voor displaytime om te zien
    {
        if (timeToDisplay < 0) // als de tijd kleiner is dan 0
        {
            timeToDisplay = 0; // dan is de tijd die er staat 0 
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);  // indien er meer dan 60 seconden zorgt dit ervoor dat er een minuut word gedisplayed
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // dit displayed de overige seconden van de 60 seconden
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); //de minutes en seconden worden in een string format gezet dus of 0.15 of 1,00 voor minuten
    }
}
