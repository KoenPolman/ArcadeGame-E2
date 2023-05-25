using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    [SerializeField] private float velocity = 10;
    [SerializeField] private float expirationDate = 600;
    [SerializeField] private Rigidbody2D rb;
    private float lifeSpan = 0;
    private void Start()
    {
        rb.velocity = (new Vector3(0, (-1 * velocity), 0));
    }
    private void Update()
    {
        if (lifeSpan > expirationDate)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        lifeSpan++;
    }
}
