using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    //dit zijn alle prefabs die door dit script in gespawnd worden
    [SerializeField] GameObject Dumpster = null; 
    [SerializeField] GameObject FuelCan = null; 
    [SerializeField] GameObject Bottle = null; 
    [SerializeField] GameObject PizzaAndCan = null; 
    [SerializeField] GameObject Stump = null; 
    [SerializeField] GameObject Patoo1 = null;
    [SerializeField] GameObject Patoo2 = null;
    [SerializeField] GameObject Clock = null; 
    [SerializeField] GameObject Potion = null;

    //timeBetweenObstacles telt langzaam op waarmee de kans om een obstakel te spawnen groter word met tijd
    private float timeBetweenObstacles = -400;
    //tijd waarna het gegarandeerd is dat er een obstacle word in gespawned
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
                    GameObject obstacleDumpster = Instantiate(Dumpster);
                    ObstaclePlacer(obstacleDumpster);
                    break;
                case 2:
                    GameObject obstacleFuelCan = Instantiate(FuelCan);
                    ObstaclePlacer(obstacleFuelCan);
                    break;
                case 3:
                    GameObject obstacleBottle = Instantiate(Bottle);
                    ObstaclePlacer(obstacleBottle);
                    break;
                case 4:
                    GameObject obstaclePizzaAndCan = Instantiate(PizzaAndCan);
                    ObstaclePlacer(obstaclePizzaAndCan);
                    break;
                case 5:
                    GameObject obstacleStump = Instantiate(Stump);
                    ObstaclePlacer(obstacleStump);
                    break;
                case 6:
                    GameObject obstacleClock = Instantiate(Clock);
                    ObstaclePlacer(obstacleClock);
                    break;
                case 7:
                    GameObject obstaclePotion = Instantiate(Potion);
                    ObstaclePlacer(obstaclePotion);
                    break;
            }
            timeBetweenObstacles = -50;
            maxSpaceBetweenObstacles = maxSpaceBetweenObstacles - 10;
        }
        timeBetweenObstacles++;
        Debug.Log(timeBetweenObstacles);
    }
    private void ObstaclePlacer(GameObject placedGameObject)
    {
        float positionPicker = Random.Range(-2, 3);
        positionPicker =+-0.5625f;
        placedGameObject.transform.position = new Vector3(positionPicker, 10f, 0f);
    }
}
