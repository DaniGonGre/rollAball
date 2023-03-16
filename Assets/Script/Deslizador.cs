using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deslizador : MonoBehaviour
{
    
    public float speed = 5.0f;
    public float leftLimit = -5.0f;
    public float rightLimit = 5.0f;
    private bool movimiento = true;

    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            movimiento = true;
        }
        else if (transform.position.x > rightLimit)
        {
            movimiento = false;
        }

        if (movimiento)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}

