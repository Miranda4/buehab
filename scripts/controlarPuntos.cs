using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarPuntos : MonoBehaviour
{
    public static controlarPuntos instance;

    [SerializeField] public float cantidadPuntosEnergiaP;
    [SerializeField] public float cantidadPuntosFelicidadP;
    [SerializeField] public float cantidadPuntosAlimentacionP;
    [SerializeField] public float cantidadPuntosAtencionP;
    [SerializeField] public float cantidadPuntosCondicionP;
    [SerializeField] public float cantidadPuntosMotivacionP;

    [SerializeField] public float cantidadPuntos;

    [SerializeField] public float cantidadPuntosIrritabilidad;
    [SerializeField] public float cantidadPuntosSalud;
    [SerializeField] public float cantidadPuntosDepresion;
    [SerializeField] public float cantidadPuntosAnsiedad;
    [SerializeField] public float cantidadPuntosEstres;
    [SerializeField] public float cantidadPuntosEnergia;
    [SerializeField] public float cantidadPuntosObesidad;
    [SerializeField] public float cantidadPuntosFelicidad;


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




    public void sumarCantidadObesidad(float puntos)
    {
        cantidadPuntosObesidad += puntos;
    }

    //restablecer puntajes 
    public void restablecerPuntaje()
    {
        cantidadPuntos = 0;
    }

    public void restablecerPuntajeMotivacionP()
    {
        cantidadPuntosMotivacionP = 0;
    }

    public void restablecerPuntajeCondicionP()
    {
        cantidadPuntosCondicionP = 0;
    }

    public void restablecerPuntajeAtencionP()
    {
        cantidadPuntosAtencionP= 0;
    }

    public void restablecerPuntajeFelicidadP()
    {
        cantidadPuntosFelicidadP = 0;
    }

    public void restablecerPuntajeEnergiaP()
    {
        cantidadPuntosEnergiaP = 0;
    }

    public void restablecerPuntajeAlimentacionP()
    {
        cantidadPuntosAlimentacionP = 0;
    }


    public void sumarPuntosCondicionP(float puntos)
    {
        cantidadPuntosCondicionP+= puntos;
    }

    public void sumarPuntosAtencionP(float puntos)
    {
        cantidadPuntosAtencionP += puntos;
    }

    public void sumarPuntosAlimentacionP(float puntos)
    {
        cantidadPuntosAlimentacionP += puntos;
    }

    public void sumarPuntosFelicidadP(float puntos)
    {
        cantidadPuntosFelicidadP += puntos;
    }

    public void sumarPuntosEnergiaP(float puntos)
    {
        cantidadPuntosEnergiaP += puntos;
    }

    public void sumarPuntosMotivacionP(float puntos)
    {
        cantidadPuntosMotivacionP += puntos;
    }


    public void sumarPuntosAnsiedad(float puntos)
    {
        cantidadPuntosAnsiedad += puntos;
    }

    public void sumarPuntosDepresion(float puntos)
    {
        cantidadPuntosDepresion += puntos;
    }

    public void sumarPuntosEstres(float puntos)
    {
        cantidadPuntosEstres += puntos;
    }

    public void sumarPuntosIrritabilidad(float puntos)
    {
        cantidadPuntosIrritabilidad += puntos;
    }

    public void sumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
    }

    public void sumarPuntosFelicidad(float puntos)
    {
        cantidadPuntosFelicidad += puntos;
    }

    public void sumarPuntosEnergia(float puntos)
    {
        cantidadPuntosEnergia += puntos;
    }

    public void sumarPuntosSalud(float puntos)
    {
        cantidadPuntosSalud += puntos;
    }


}