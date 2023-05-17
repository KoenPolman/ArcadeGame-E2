using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinGame : MonoBehaviour
{
    void Start()
    {

        int num1 = GetNum();
        int num2 = GetNum();

        int opp = Random.Range(1, 3);
        print(opp);

    }

    int GetNum()
    {
        int num = Random.Range(100, 1000);
        return num;
    }
}
