using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    private float timeBetweenObstacles = -100;
    //tijd waarna het gegarandeerd is dat er een obstacle word in gespawned
    public float maxSpaceBetweenObstacles = 800;
    private void FixedUpdate()
    {
        float num = Random.Range(1, maxSpaceBetweenObstacles);
        if (num <= timeBetweenObstacles)
        {
            float obstaclePicker = Random.Range(1, 8);
            float positionPicker = Random.Range(-2, 3);
            switch (obstaclePicker)
            {
                case 1:
                    GameObject obstacleDumpster = Instantiate(Dumpster, new Vector3(positionPicker, 10f, 0f), Quaternion.identity);
                    break;
                case 2:
                    GameObject obstacleFuelCan = Instantiate(FuelCan, new Vector3(positionPicker, 10f, 0f), Quaternion.identity);
                    break;
                case 3:
                    GameObject obstacleBottle = Instantiate(Bottle, new Vector3(positionPicker, 10f, 0f), Quaternion.identity);
                    break;
                case 4:
                    GameObject obstaclePizzaAndCan = Instantiate(PizzaAndCan, new Vector3(positionPicker, 10f, 0f), Quaternion.identity);
                    break;
                case 5:
                    GameObject obstacleStump = Instantiate(Stump, new Vector3(positionPicker, 10f, 0f), Quaternion.identity);
                    break;
                case 6:
                    GameObject obstacleClock = Instantiate(Clock, new Vector3(positionPicker, 10f, 0f), Quaternion.identity);
                    break;
                case 7:
                    GameObject obstaclepotion = Instantiate(Potion, new Vector3(positionPicker, 10f, 0f), Quaternion.identity);
                    break;
            }
            timeBetweenObstacles = -50;
            maxSpaceBetweenObstacles = maxSpaceBetweenObstacles - 10;
            Debug.Log(maxSpaceBetweenObstacles);
            Debug.Log(positionPicker);
        }
        timeBetweenObstacles++;
    }
}
