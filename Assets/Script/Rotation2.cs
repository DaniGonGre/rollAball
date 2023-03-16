using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotation2 : MonoBehaviour {

    public float velocidadRotacion = 50f;
    void Update () {
        transform.Rotate(velocidadRotacion * Time.deltaTime, 0f, velocidadRotacion * Time.deltaTime);
    }
}
