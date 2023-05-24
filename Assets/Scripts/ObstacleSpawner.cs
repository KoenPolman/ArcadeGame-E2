using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject Dumpster = null; 
    [SerializeField] GameObject FuelCan = null; 
    [SerializeField] GameObject Bottle = null; 
    [SerializeField] GameObject PizzaAndCan = null; 
    [SerializeField] GameObject Stump = null; 
    [SerializeField] GameObject Patoo1 = null;
    [SerializeField] GameObject Patoo2 = null;
    [SerializeField] GameObject Clock = null; 
    [SerializeField] GameObject Potion = null;

    private float timeBetweenObstacles = -400;
    private float maxSpaceBetweenObstacles = 400;
    private void FixedUpdate()
    {
        float num = Random.Range(1, maxSpaceBetweenObstacles);
        if (num <= timeBetweenObstacles)
        {
            float obstaclePicker = Random.Range(1, 8);
            switch (obstaclePicker)
            {
                case 1:
                    GameObject newObstacle = Instantiate(Dumpster);
                    break;
                case 2:
                    GameObject newObstacle = Instantiate(Dumpster);
                    break;
                case 3:
                    GameObject newObstacle = Instantiate(Dumpster);
                    break;
                case 4:
                    GameObject newObstacle = Instantiate(Dumpster);
                    break;
                case 5:
                    GameObject newObstacle = Instantiate(Dumpster);
                    break;
                case 6:
                    GameObject newObstacle = Instantiate(Dumpster);
                    break;
                case 7:
                    GameObject newObstacle = Instantiate(Dumpster);
                    break;
            }
            timeBetweenObstacles = -50;
            maxSpaceBetweenObstacles = maxSpaceBetweenObstacles - 10;
        }
        lifeSpan++;
    }
}
