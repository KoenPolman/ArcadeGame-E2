using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathRepeater : MonoBehaviour
{
    [SerializeField] GameObject Grid = null;
    private float lifeSpan = 1;
    private float interval = 1250;
    private void FixedUpdate() // zorgt ervoor dat het pad zichzelf steeds herhaalt
    {
        if (lifeSpan % interval == 0)
        {
            GameObject newGrid = Instantiate(Grid);
            newGrid.transform.position = new Vector3(-0.5625f, 31f, 0f);
        }
        lifeSpan++;
    }
}
