using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotation : MonoBehaviour {

    public float velocidadRotacion = 50f;
    void Update () {
        transform.Rotate(0f, velocidadRotacion * Time.deltaTime, 0f);
    }
}
