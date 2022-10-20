using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarPuntos : MonoBehaviour
{
    public static controlarPuntos instance;

    [SerializeField] public float cantidadPuntos;
    [SerializeField] public float cantidadPuntosFelicidad;
    [SerializeField] public float cantidadPuntosSueno;
    [SerializeField] public float cantidadPuntosEnergia;
    [SerializeField] public float cantidadPuntosTristeza;
    [SerializeField] public float cantidadPuntosDesagrado;
    [SerializeField] public float cantidadPuntosEnojo;


    private void Awake()
    {
        if(controlarPuntos.instance == null)
        {
            controlarPuntos.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void restablecerPuntaje()
    {
        cantidadPuntos = 0;
    }

    public void sumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
    }

    public void sumarPuntosFelicidad(float puntos)
    {
        cantidadPuntosFelicidad += puntos;
    }
    public void sumarPuntosSueno(float puntos)
    {
        cantidadPuntosSueno += puntos;
    }
    public void sumarPuntosEnergia(float puntos)
    {
        cantidadPuntosEnergia += puntos;
    }
    public void sumarPuntosTristeza(float puntos)
    {
        cantidadPuntosTristeza += puntos;
    }
    public void sumarPuntosDesagrado(float puntos)
    {
        cantidadPuntosDesagrado += puntos;
    }
    public void sumarPuntosEnojo(float puntos)
    {
        cantidadPuntosEnojo += puntos;
    }

}