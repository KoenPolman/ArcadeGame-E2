using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockBehavior : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) // deze method zorgt ervoor dat als je een klok aanraakt/oppakt dat je langer kan spelen
    {
        ObstacleSpawner spawner = FindObjectOfType<ObstacleSpawner>();
        spawner.maxSpaceBetweenObstacles += 50;
        Destroy(gameObject);
    }
}
