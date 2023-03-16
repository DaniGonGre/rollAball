using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntuacion : MonoBehaviour
{
    //public Text textoPuntuacion;
    private int contador;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Moneda"))
        {
            contador++;
            //textoPuntuacion.text = "Puntuacion: " + contador;
        }
    }
}
