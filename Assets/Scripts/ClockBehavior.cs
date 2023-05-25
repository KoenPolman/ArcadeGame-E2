using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockBehavior : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        ObstacleSpawner spawner = FindObjectOfType<ObstacleSpawner>();
        spawner.maxSpaceBetweenObstacles += 50;
        Destroy(gameObject);
    }
}
