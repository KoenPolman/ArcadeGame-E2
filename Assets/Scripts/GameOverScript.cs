using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text highScoreText;
    public Text scoreText;
    float score;
    float highScore;

    public void Start()
    {
        score = PlayerPrefs.GetFloat("score: ", score);
        scoreText.text = scoreText.ToString();

        highScore = PlayerPrefs.GetFloat("highScore: ", MathF.Ceiling(highScore));
        highScoreText.text = highScore.ToString();
    }
}
