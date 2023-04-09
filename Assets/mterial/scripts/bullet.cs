using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public GameObject effectOfDeth;
    public Transform pointOfDethEffect;

    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, lifeTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(effectOfDeth, pointOfDethEffect.position, transform.rotation);
        Destroy(gameObject);

    }
}
