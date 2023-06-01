using UnityEngine;
using UnityEngine.UI;
using System;

public class Scoring : MonoBehaviour
{
    public Text scoreText;
    //public Text highText;
    public float timer;
    public float score;
    public float highScore;
    void Start()
    {
        score = 0;
        //highScore = PlayerPrefs.GetFloat("highScore: ");
        PlayerPrefs.SetFloat("score: ", score);
        //score = PlayerPrefs.GetFloat("score: ");
    }
    public void Update() // zorgt ervoor dat de scores worden geupdate om een bepaalde tijd
    {
        scoreText.text = score.ToString();
        //highText.text = highScore.ToString();
        timer += Time.deltaTime;
        if (timer > 3)
        {
            PlayerPrefs.SetFloat("score: ", score);
            score += 1;
            timer = 0;
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetFloat("highScore: ", MathF.Ceiling(highScore));
            }
        }
    }
}
