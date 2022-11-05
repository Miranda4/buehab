using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionActivaDesactiva : MonoBehaviour
{
    public GameObject jugador;
    public GameObject juego;
    public GameObject botonReinicio;

    void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject == jugador)
        {
            botonReinicio.gameObject.SetActive(true);
            Destroy(jugador.gameObject);

        }
    }
}
