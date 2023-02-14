using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    [SerializeField]
    float maxSpeed = 10;

    private void FixedUpdate()
    {
        float inputH = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(inputH * maxSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }
}
