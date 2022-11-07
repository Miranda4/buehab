using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class consumoReinicio : MonoBehaviour
{
    private static controlarPuntos controlarPuntos;
    public GameObject botonReinicio;
    public GameObject botonContinuar;
    public GameObject jugador;
    public GameObject spawners;
    public float puntosGanar;


    private void Start()
    {
        controlarPuntos = FindObjectOfType<controlarPuntos>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == jugador)
        {
            if (controlarPuntos.cantidadPuntos < 0)
            {
                botonReinicio.SetActive(true);
                Destroy(jugador.gameObject);
                Destroy(spawners.gameObject);
            }
            else if(controlarPuntos.cantidadPuntos >= puntosGanar)
            {
                Destroy(spawners.gameObject);
                Destroy(jugador.gameObject);
                botonContinuar.SetActive(true);
            }
        }
    }
}
