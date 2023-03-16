using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // velocidad del player
    public float speed = 2; 
    public String saludo = "Hola";

    private Rigidbody rb;

    public float movementX = 0;
    public float movementY = 0;

    public TextMeshProUGUI textoPuntuacion;
    private int contador;

    private Vector3 posicion_bola;

    // Start is called before the first frame update
    void Start()
    {
        // instanciando el objeto que contiene este script
        // la bola
        rb = GetComponent<Rigidbody>();
        // mensaje para la consola del Unity
        // Debug.Log("Estoy en Start ");

		if (posicion_bola.y < 0) {
       	    // Establecer la posición de la bola en la posición deseada
            posicion_bola = new Vector3(-4.83f, 2.702f, 12.72708f);
            transform.position = posicion_bola; // Actualizar la posición de la bola en la escena
        } 
    }

    /**
     *  Evento Input System
     **/
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
        // mensaje para la consola del Unity
        // Debug.Log("X: " + movementX.ToString());
        // Debug.Log("Y: " + movementY.ToString());

    }

    private void FixedUpdate()
    {
        
        // para el teclado
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other)
    {

       if (other.gameObject.CompareTag("Moneda"))
        {
            contador++;
			Debug.Log("colision");
			SetCountText();
            other.gameObject.SetActive(false);

        }

    }

	private void SetCountText()
	{

        textoPuntuacion.text = "Puntuacion: " + contador.ToString();

	}


}

