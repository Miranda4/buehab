using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoPuntos : MonoBehaviour
{
    [SerializeField] private int cantidadPuntos;
    [SerializeField] private puntaje puntaje;

    [SerializeField] private int cantidadPuntosFelicidad;
    [SerializeField] private puntajeFelicidad puntajeFelicidad;

    [SerializeField] private int cantidadPuntosSueno;
    [SerializeField] private puntajeSueno puntajeSueno;

    [SerializeField] private int cantidadPuntosEnergia;
    [SerializeField] private puntajeEnergia puntajeEnergia;

    [SerializeField] private int cantidadPuntosTristeza;
    [SerializeField] private puntajeTristeza puntajeTristeza;

    [SerializeField] private int cantidadPuntosDesagrado;
    [SerializeField] private puntajeDesagrado puntajeDesagrado;

    [SerializeField] private int cantidadPuntosEnojo;
    [SerializeField] private puntajeEnojo puntajeEnojo;

    [SerializeField] private string escena;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //puntaje general del objeto para mostar en general
            controlarPuntos.instance.sumarPuntos(cantidadPuntos);
            puntaje.SumarPuntos(cantidadPuntos);

            controlarPuntos.instance.sumarPuntosFelicidad(cantidadPuntosFelicidad);
            puntajeFelicidad.SumarPuntosFelicidad(cantidadPuntosFelicidad);

            controlarPuntos.instance.sumarPuntosSueno(cantidadPuntosSueno);
            puntajeSueno.SumarPuntosSueno(cantidadPuntosSueno);

            controlarPuntos.instance.sumarPuntosEnergia(cantidadPuntosEnergia);
            puntajeEnergia.SumarPuntosEnergia(cantidadPuntosEnergia);

            controlarPuntos.instance.sumarPuntosTristeza(cantidadPuntosTristeza);
            puntajeTristeza.SumarPuntosTristeza(cantidadPuntosTristeza);

            controlarPuntos.instance.sumarPuntosDesagrado(cantidadPuntosDesagrado);
            puntajeDesagrado.SumarPuntosDesagrado(cantidadPuntosDesagrado);

            controlarPuntos.instance.sumarPuntosEnojo(cantidadPuntosEnojo);
            puntajeEnojo.SumarPuntosEnojo(cantidadPuntosEnojo);

            Destroy(gameObject);
        }
    }
}
