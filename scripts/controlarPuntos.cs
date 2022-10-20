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
    [SerializeField] public float cantidadPuntosSalud;
    [SerializeField] public float cantidadPuntosEnojo;

    //puntos de el usuario
    [SerializeField] public float felicidad;
    [SerializeField] public float sueno;
    [SerializeField] public float energia;
    [SerializeField] public float tristeza;
    [SerializeField] public float salud;
    [SerializeField] public float enojo;


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


    public void sumarFelicidad(float puntos)
    {
        felicidad += puntos;
    }
    public void sumarSueno(float puntos)
    {
        sueno += puntos;
    }
    public void sumarEnergia(float puntos)
    {
        energia += puntos;
    }
    public void sumarTristeza(float puntos)
    {
        tristeza += puntos;
    }
    public void sumarSalud(float puntos)
    {
        salud += puntos;
    }
    public void sumarEnojo(float puntos)
    {
        enojo += puntos;
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
    public void sumarPuntosSalud(float puntos)
    {
        cantidadPuntosSalud += puntos;
    }
    public void sumarPuntosEnojo(float puntos)
    {
        cantidadPuntosEnojo += puntos;
    }

}