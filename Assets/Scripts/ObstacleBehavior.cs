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
        float positionPicker = Random.Range(-2, 3);
        positionPicker = +-0.5625f;
        rb.transform.position = new Vector3(positionPicker, 10f, 0f);
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
