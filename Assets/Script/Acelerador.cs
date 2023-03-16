using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerador : MonoBehaviour
{
public float velocidadAceleracion = 4f;

private void OnCollisionEnter(Collision other)
{
    if (other.gameObject.CompareTag("Suelo"))
    {
        GetComponent<Rigidbody>().velocity *= velocidadAceleracion;
    }
}
}
