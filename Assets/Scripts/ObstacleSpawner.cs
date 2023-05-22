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
    private float lifeSpan = -400;
    private float maxSpaceBetweenObstacles = 400;
    private void FixedUpdate()
    {
        float num = Random.Range(1, maxSpaceBetweenObstacles);
        if (num <= lifeSpan)
        {
            float obstaclePicker = Random.Range(1, 8);
            switch (obstaclePicker)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
            lifeSpan = -50;
            maxSpaceBetweenObstacles = maxSpaceBetweenObstacles - 10;
        }
        lifeSpan++;
    }
}
