using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Playermovement : MonoBehaviour
{
    public float timer;
    public float score;
    public float highScore;
    float playerposition = 0;
    [SerializeField] private Rigidbody2D rb;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();//het aan wijzen van de rigidbody van het speler character
    }
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            playerposition++;
        }
        else if (Input.GetKeyDown("a"))
        {
            playerposition--;
        }
        if (playerposition < -2)
        {
            playerposition = -2;
        }
        else if (playerposition > 2) 
        {
            playerposition = 2;       
        }
        transform.position = new Vector3(playerposition,-4,0);
    }
    void FixedUpdate()
    {
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
