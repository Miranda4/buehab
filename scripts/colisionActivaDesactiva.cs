using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionActivaDesactiva : MonoBehaviour
{
    public GameObject jugador;
    public GameObject juego;
    public GameObject resumen;

    void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject == jugador)
        {
            juego.gameObject.SetActive(false);
            resumen.gameObject.SetActive(true);
        }
    }
}
