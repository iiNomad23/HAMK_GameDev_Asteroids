using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_1 : MonoBehaviour
{ 
    [SerializeField]
    private float minScale = 0.5f;
    [SerializeField]
    private float maxScale = 2;

    private float randomScale;

    private void Start()
    {      
        randomScale = Random.Range(minScale, maxScale);
        gameObject.transform.localScale = new Vector2(randomScale, randomScale);
    }

    private void FixedUpdate()
    {
        if (gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
