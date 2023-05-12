using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
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
}
