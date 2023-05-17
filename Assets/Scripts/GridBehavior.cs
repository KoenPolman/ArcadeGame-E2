using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehavior : MonoBehaviour
{
    [SerializeField] private float velocity = 10;
    [SerializeField] private float expirationDate = 1500;
    private float lifeSpan = 0;
    [SerializeField] private Rigidbody2D rb;
    void Start()
    {
        rb.AddForce(new Vector3(0, (-1 * velocity), 0));
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeSpan > expirationDate)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        lifeSpan++;
    }
}
